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
using System.Drawing.Imaging;
using System.Reflection;

namespace MySlideShow
{

    public partial class MainForm : Form
    {

        // default video parameters
        private const string DEFAULT_OUTPUT_FILE = "photos.avi";
        private const string DEFAULT_SORTING_METHOD = "title";

        public MainForm()
        {
            InitializeComponent();

            // set default values in the form
            videoCodecComboBox.SelectedIndex = 0;
            titleSortRadio.Checked = true;

        }

        private void photoDirBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if ( !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath) )
            {
                photoDirTextBox.Text = folderBrowserDialog1.SelectedPath;
                videoOutputTextBox.Text = photoDirTextBox.Text + "\\" +
                    DEFAULT_OUTPUT_FILE;
            }
        }

        private void directoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void videoOutputBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if( !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                videoOutputTextBox.Text = folderBrowserDialog1.SelectedPath + "\\" + DEFAULT_OUTPUT_FILE;
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            // photo directory can be empty
            // handle this exception and throw an error
            string photoDirectory = photoDirTextBox.Text;
            if (String.IsNullOrWhiteSpace(photoDirectory))
            {
                MessageBox.Show( "Photo directiry can't be empty!", "Input data error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if( !Directory.Exists(photoDirectory))
            {
                MessageBox.Show("Directory " + photoDirectory +" doesn't exist", 
                    "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrWhiteSpace(videoOutputTextBox.Text))
            {
                MessageBox.Show("Video output file name can't be empty!",
                    "Input data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // pass all necessary parameters from MainForm to ProgressForm
            string sortingMethod = titleSortRadio.Checked ?
               "creation time" : timeSortRadio.Checked ?
               "title" : randomSortRadio.Checked ?
               "random" : DEFAULT_SORTING_METHOD;

            string videoOutputFile =
                !String.IsNullOrWhiteSpace(videoOutputTextBox.Text) ?
                 videoOutputTextBox.Text : DEFAULT_OUTPUT_FILE;

            string videoCodecName = videoCodecComboBox.SelectedText;
            int slideDuration = (int)slideDurationNumUpDown.Value;

            ProgressForm progressForm = new ProgressForm(
                sortingMethod,
                photoDirectory,
                videoOutputFile,
                videoCodecName,
                slideDuration
            );

            progressForm.Show();
        }

    }
}
