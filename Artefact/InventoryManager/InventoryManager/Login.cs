using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSubmit;
        }

        string cs = @"Data Source= (LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Users.mdf;Integrated Security = True;";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a User ID and Password");
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Login WHERE UserID = @userid AND Password = @password", con);
                cmd.Parameters.AddWithValue("@userid", txtUserID.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    LoggedUser.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                    LoggedUser.UserID = txtUserID.Text;
                    this.Hide();
                    frmOverview fo = new frmOverview();
                    fo.Show();
                }
                
                else
                {
                    MessageBox.Show("Login Failed");
                    txtPassword.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
