using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.FFMPEG;
using System.Collections;
using System.Drawing.Drawing2D;

namespace MySlideShow
{
    public partial class ProgressForm : Form
    {
        public string sortingMethod, photoDirectory, videoCodecName;
        public int slideDuration;

        private static string videoOutputFile;
        public static void SetOutputFile(string outputFile)
        {
            videoOutputFile = outputFile;
        }

        public static string GetOutputFile()
        {
            return videoOutputFile;
        }

        public ProgressForm()
        {
            InitializeComponent();

            recordVideoBackgroundWorker = new BackgroundWorker();

            recordVideoBackgroundWorker.WorkerReportsProgress = true;
            recordVideoBackgroundWorker.WorkerSupportsCancellation = true;

            recordVideoBackgroundWorker.DoWork +=
                new DoWorkEventHandler(recordVideoBackgroundWorker_DoWork);

            recordVideoBackgroundWorker.ProgressChanged +=
                new ProgressChangedEventHandler(recordVideoBackgroundWorker_ProgressChanged);

            recordVideoBackgroundWorker.RunWorkerCompleted +=
              new RunWorkerCompletedEventHandler(recordVideoBackgroundWorker_RunCompleted);

            recordVideoBackgroundWorker.RunWorkerAsync();
        }

        private static VideoFileWriter writer = new VideoFileWriter();
        private void recordVideoBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            // get only images from a chosen directory including subdirectories
            var ext = new List<string> { ".jpg", ".gif", ".png" };
            string[] photos = Directory.GetFiles(photoDirectory, "*.*",
                SearchOption.AllDirectories).
                Where(s => ext.Any(el => s.EndsWith(el, true, null))).
                ToArray();

            // sort photos
            SortPhotos(photos, sortingMethod);

            // get a corresponding video codec
            VideoCodec codec = GetVideoCodec(videoCodecName);

            // size of video frame
            int width = 4000;
            int height = 3000;

            // create instance of video writer

            writer.Open(videoOutputFile, width, height, 1, codec);

            int progress = 0;
            for (int i = 0; i < photos.Length; i++)
            {

                string photoName = photos[i];
                ProcessOnePhoto(
                    photoName,
                    width,
                    height,
                    slideDuration,
                    writer
                );

                progress += (int)(100 / photos.Length);
                recordVideoBackgroundWorker.ReportProgress(progress);
            }
            writer.Close();
        }

        private void recordVideoBackgroundWorker_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            int percentValue = e.ProgressPercentage >= 100 ?
                100 : e.ProgressPercentage;

            recordingProgressBar.Value = percentValue;
        }

        private void recordVideoBackgroundWorker_RunCompleted(object sender,
            RunWorkerCompletedEventArgs e)
        {
            recordingProgressBar.Value = 100;
            cancelBtn.Enabled = false;
            finishBtn.Enabled = true;
        }

        private static void ProcessOnePhoto(
           string photoName,
           int width,
           int height,
           int slideDuration,
           VideoFileWriter writer
           )
        {
            // get image of current photo
            Image photoImg = Image.FromFile(photoName);
            Bitmap frameBmp = new Bitmap(photoImg, width, height);
            photoImg.Dispose();

            // paint frame in black
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            Graphics gOff = Graphics.FromImage(frameBmp);
            gOff.SmoothingMode = SmoothingMode.HighQuality;
            gOff.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gOff.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gOff.FillRectangle(BlackBrush, 0, 0, width, height);

            // rescaling the image
            Bitmap photoBmp = ResizeImage(photoName, width, height);

            // get a position for the photo in the rectangle
            Point photoPos = GetImageLocationInRectangle(photoBmp, width, height);
            // locate the photo in the middle of the black rectangle
            gOff.DrawImage(photoBmp,
                photoPos.X, photoPos.Y,
                photoBmp.Width, photoBmp.Height);
            gOff.Dispose();
            photoBmp.Dispose();

            for (var counter = 1; counter <= slideDuration; counter++)
            {
                writer.WriteVideoFrame(frameBmp);
            }

            frameBmp.Dispose();
        }

        private static VideoCodec GetVideoCodec(string codecName)
        {
            switch (codecName)
            {
                case "MPEG4": return VideoCodec.MPEG4;
                case "MPEG2": return VideoCodec.MPEG2;
                case "FLV1": return VideoCodec.FLV1;
                case "WMV1": return VideoCodec.WMV1;
                case "WMV2": return VideoCodec.WMV2;
                case "MSMPEG4v2": return VideoCodec.MSMPEG4v2;
                case "MSMPEG4v3": return VideoCodec.MSMPEG4v3;
                default: return VideoCodec.MPEG4;
            }
        }

        // implemented comparer for sorting by photos' creation time
        private class CreationTimeComparer : IComparer
        {
            public int Compare(Object x, Object y)
            {
                return DateTime.Compare(
                    File.GetCreationTime((String)x), File.GetCreationTime((String)y)
                );
            }
        }

        private static void SortPhotos(string[] photos, string sortingMethod)
        {
            switch (sortingMethod)
            {
                case ("creation time"):
                    IComparer myComparer = new CreationTimeComparer();
                    Array.Sort(photos, myComparer);
                    break;

                case ("random"):
                    // create random permutation of photos array
                    Random rnd = new Random();
                    photos = photos.OrderBy(x => rnd.Next()).ToArray();
                    break;

                // be default photos are sorted by a title
                case ("title"):
                default:
                    Array.Sort(photos);
                    break;
            }
        }

        private static Point GetImageLocationInRectangle(
                Bitmap bmpImage,
                int width,
                int height
            )
        {
            Point position = new Point();
            if (bmpImage.Width > bmpImage.Height)
            {
                position.Y = (height - bmpImage.Height) / 2;
            }
            else if (bmpImage.Height > bmpImage.Width)
            {
                position.X = (width - bmpImage.Width) / 2;
            }
            else
            {
                position.X = 0;
                position.Y = 0;
            }

            return position;
        }

        private static Bitmap ResizeImage(
                string imgName,
                int frameWidth,
                int frameHeight
            )
        {
            Image img = Image.FromFile(imgName);

            int imgHeight = img.Height;
            int imgWidth = img.Width;

            // in order to get right width and height it's needed 
            // to get an orientation of photo.
            // If the photo was rotated before, its width and height can be mixed up.
            if (img.PropertyIdList.Contains(0x0112))
            {
                var orientation = (int)img.GetPropertyItem(0x0112).Value[0];
                switch (orientation)
                {
                    case 1:
                        // No rotation required.
                        break;
                    case 5:
                        imgHeight = img.Width;
                        imgWidth = img.Height;
                        img.RotateFlip(RotateFlipType.Rotate90FlipX);
                        break;
                    case 6:
                        imgHeight = img.Width;
                        imgWidth = img.Height;
                        img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 7:
                        imgHeight = img.Width;
                        imgWidth = img.Height;
                        img.RotateFlip(RotateFlipType.Rotate270FlipX);
                        break;
                    case 8:
                        imgHeight = img.Width;
                        imgWidth = img.Height;
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }
            }

            float newHeight, newWidth;

            // image rescaling
            if (imgHeight > imgWidth)
            {
                newHeight = frameHeight;
                newWidth = ((imgWidth * newHeight) / imgHeight);
            }
            else if (imgHeight < imgWidth)
            {
                newWidth = frameWidth;
                newHeight = ((imgHeight * newWidth) / imgWidth);
            }
            else
            {
                newHeight = frameHeight < frameWidth ?
                    frameHeight : frameWidth;
                newWidth = newHeight;
            }

            Bitmap newImg = new Bitmap(img, (int)newWidth, (int)newHeight);
            img.Dispose();

            return newImg;
        }

        private void ProgressForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            recordVideoBackgroundWorker.CancelAsync();
            writer.Close();
            if ( File.Exists(videoOutputFile) )
            {
                File.Delete(videoOutputFile);
            }

            Close();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            Close();
            Form SuccessForm = new SuccessForm();
            SuccessForm.Show();
        }
    }
}
