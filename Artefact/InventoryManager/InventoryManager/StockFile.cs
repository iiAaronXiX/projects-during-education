using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InventoryManager
{
    public partial class frmStockFile : Form
    {

        public OleDbConnection DataConnection = new OleDbConnection();

        public frmStockFile()
        {
            InitializeComponent();
        }

        private void StockFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.stockDataSet.items);

            this.AcceptButton = btnSearch;

            cmbType.SelectedItem = "";

            lblName.Text = LoggedUser.Name;
            lblUserID.Text = LoggedUser.UserID;
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOverview fo = new frmOverview();
            fo.Show();
        }

        private void btnAmend_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAmendStock fas = new frmAmendStock();
            fas.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful!");
            this.Close();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SKU = string.IsNullOrEmpty(txtSKU.Text) ? "%" : txtSKU.Text;
            string Name = string.IsNullOrEmpty(txtName.Text) ? "%" : txtName.Text;
            string Type = string.IsNullOrEmpty(cmbType.Text) ? "%" : cmbType.Text;

            string Select = "SELECT * FROM items WHERE SKU LIKE '" + SKU + "' AND Product_Name LIKE '" + Name + "' AND Type LIKE '" + Type + "'";

            string cs="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\stock.mdb";

            DataConnection = new OleDbConnection(cs);

            OleDbDataAdapter ida = new OleDbDataAdapter(Select, DataConnection);

            try 
            {
                stockDataSet.items.Clear();
                ida.Fill(this.stockDataSet.items);
            }
            catch(OleDbException exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }
        }
    }
}
