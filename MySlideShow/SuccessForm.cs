using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySlideShow
{
    public partial class SuccessForm : Form
    {
        public string videoOutputFile;
        public SuccessForm(string videoOutputFile)
        {
            InitializeComponent();

            this.videoOutputFile = videoOutputFile;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            // play slide show video
            System.Diagnostics.Process.Start(videoOutputFile);
        }
    }


}
