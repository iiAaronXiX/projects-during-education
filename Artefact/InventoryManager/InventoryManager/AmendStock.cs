using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.IO;

namespace InventoryManager
{
    public partial class frmAmendStock : Form
    {

        public OleDbConnection DataConnection = new OleDbConnection();


        public frmAmendStock()
        {
            InitializeComponent();
        }

        public void RefreshForm()
        {
            try
            {
                lblLastChecked.Text = "";
                lblPrice.Text = "";
                lblStock.Text = "";
                lblStockCounted.Text = "";

                string SKU = txtSKU.Text;

                string Select = "SELECT * FROM items WHERE SKU LIKE '" + SKU + "'";
                string cs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\stock.mdb";

                DataConnection = new OleDbConnection(cs);

                OleDbDataAdapter ida = new OleDbDataAdapter(Select, DataConnection);
                DataSet product = new DataSet();

                ida.Fill(product);

                foreach (DataRow dr in product.Tables[0].Rows)
                {
                    lblLastChecked.Text += Convert.ToDateTime(product.Tables[0].Rows[0]["Last_Counted"]).ToString("dd/MM/yyyy");
                    lblPrice.Text += "£" + product.Tables[0].Rows[0]["Price"].ToString();
                    lblStock.Text += product.Tables[0].Rows[0]["Stock"].ToString() + " units";
                    lblStockCounted.Text += product.Tables[0].Rows[0]["Stock_Counted"].ToString() + " units";

                    byte[] bimg = (byte[])product.Tables[0].Rows[0]["Image"];
                    var ms = new System.IO.MemoryStream(OleImageUnwrap.GetImageBytesFromOLEField(bimg));
                    this.pbItem.Image = new System.Drawing.Bitmap(ms);
                    ms.Close();
                }
                DataConnection.Close();
            }
            catch(NullReferenceException e)
            {
                throw new InvalidOperationException("Unable to refresh!", e);
            }
        }
        
        private void frmAmendStock_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSubmit;

            lblName.Text = LoggedUser.Name;
            lblUserID.Text = LoggedUser.UserID;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful!");
            this.Close();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblLastChecked.Text = "";
            lblPrice.Text = "";
            lblStock.Text = "";
            lblStockCounted.Text = "";

            string SKU = txtSKU.Text;
           
            string Select = "SELECT * FROM items WHERE SKU LIKE '" + SKU + "'";
            string cs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\stock.mdb";

            DataConnection = new OleDbConnection(cs);

            OleDbDataAdapter ida = new OleDbDataAdapter(Select, DataConnection);
            DataSet product = new DataSet();

            ida.Fill(product);
            if (string.IsNullOrEmpty(SKU))
            {
                MessageBox.Show("Please enter a SKU.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdjust.Visible = false;
            }
            else
            {
                foreach (DataRow dr in product.Tables[0].Rows)
                {
                    lblLastChecked.Text += Convert.ToDateTime(product.Tables[0].Rows[0]["Last_Counted"]).ToString("dd/MM/yyyy");
                    lblPrice.Text += "£" + product.Tables[0].Rows[0]["Price"].ToString();
                    lblStock.Text += product.Tables[0].Rows[0]["Stock"].ToString() + " units";
                    lblStockCounted.Text += product.Tables[0].Rows[0]["Stock_Counted"].ToString() + " units";

                    byte[] bimg = (byte[])product.Tables[0].Rows[0]["Image"];
                    var ms = new System.IO.MemoryStream(OleImageUnwrap.GetImageBytesFromOLEField(bimg));
                    this.pbItem.Image = new System.Drawing.Bitmap(ms);
                    ms.Close();
                }
                DataConnection.Close();
                btnAdjust.Visible = !btnAdjust.Visible;
            }
         }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOverview fo = new frmOverview();
            fo.Show();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            frmAdjustment fa = new frmAdjustment(this);
            fa.enteredSKU = txtSKU.Text;
            fa.Show();
        }
    }
}
