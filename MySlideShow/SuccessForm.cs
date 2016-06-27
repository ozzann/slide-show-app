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
        public SuccessForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void watchBtn_Click(object sender, EventArgs e)
        {
            string videoOutputFile = ProgressForm.GetOutputFile();
            Process.Start(videoOutputFile);
        }
    }
}
