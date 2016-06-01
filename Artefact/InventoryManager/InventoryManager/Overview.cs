using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class frmOverview : Form
    {
        public frmOverview()
        {
            InitializeComponent();
        }

        private void frmOverview_Load(object sender, EventArgs e)
        {
            lblName.Text = LoggedUser.Name;
            lblUserID.Text = LoggedUser.UserID;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful!");
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void frmOverview_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStockFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStockFile fsf = new frmStockFile();
            fsf.Show();
        }

        private void btnAmendStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAmendStock fas = new frmAmendStock();
            fas.Show();
        }

        private void btnTrouble_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrouble ft = new frmTrouble();
            ft.Show();
        }
    }
}
