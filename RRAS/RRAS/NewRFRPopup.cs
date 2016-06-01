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
    public partial class NewRFRPopup : Form
    {
        formRRAS _main;
        public NewRFRPopup(formRRAS main)
        {
            InitializeComponent();
            _main = main;
        }

        private void NewRFRPopup_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnAccept;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string newRFR = txtAlternateRFR.Text;

            if (string.IsNullOrWhiteSpace(newRFR))
            {
                MessageBox.Show("Please enter the alternate RFR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _main.AddRFR(newRFR);
                this.Close();
            }
        }
    }
}
