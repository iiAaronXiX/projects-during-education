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
    public partial class frmTrouble : Form
    {
        public frmTrouble()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful!");
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOverview fo = new frmOverview();
            fo.Show();
        }

        private void frmTrouble_Load(object sender, EventArgs e)
        {
            lblName.Text = LoggedUser.Name;
            lblUserID.Text = LoggedUser.UserID;
        }
    }
}
