using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRAS
{
    public partial class frmVideoTutorial : Form
    {
        formRRAS _main;
        public frmVideoTutorial(formRRAS main)
        {
            InitializeComponent();
            _main = main;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVideoTutorial_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"F:\Group Project\RRAS\RRAS\RRAS\Tutorial.mp4";
        }

        private void frm_close(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.close();
        }
    }
}
