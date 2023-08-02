using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CECSOAPClient
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
        }

        public ProgressDialog(string progressText, string windowTitle)
        {
            InitializeComponent();
            progText.Text = progressText;
            this.Text = windowTitle;
        }


        public void updateProgressValue(int value)
        {
            progressBar1.Value = value;
        }

        public int getProgressValue(int value) { return progressBar1.Value; }
        private void ProgressDialog_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
        }
    }
}
