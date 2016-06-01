using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RRAS
{
    public partial class formRRAS : Form
    {
        public formRRAS()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formRRAS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.tblReject_test' table. You can move, or remove it, as needed.
            this.tblReject_testTableAdapter.Fill(this.database1DataSet.tblReject_test);
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //This creates the String Publisher which grabs the information from the combo box on the form.
            //Select and Dataconnection are also defined here.
            string Department, Start_Date, End_Date, Anatomy, RFR, Comment, Select, DataConnection;
            Department = txtDepartment.Text;
            Start_Date = txtStart.Text;
            End_Date = txtEnd.Text;
            Anatomy = txtAnatomy.Text;
            RFR = cmbRFR.Text;
            Comment = txtComment.Text;

            //Select defines what should be loaded on to the dataset.
            Select = "SELECT * FROM tblReject_test WHERE =" + "'" + Department + "'";
            Select = "SELECT * FROM tblReject_test WHERE =" + "'" + Start_Date + "'";
            Select = "SELECT * FROM tblReject_test WHERE =" + "'" + End_Date + "'";
            Select = "SELECT * FROM tblReject_test WHERE = body_part_examined" + "'" + Anatomy + "'";
            Select = "SELECT * FROM tblReject_test WHERE = reject_category" + "'" + RFR + "'";
            Select = "SELECT * FROM tblReject_test WHERE = reject_comment" + "'" + Comment + "'";

            //DataConnection connects to the database.
            DataConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database1.accdb";

            //The DataAdapter is the code that ensures both the data in the Select and DataConnection strings match.
            OleDbDataAdapter bdDataAdapter = new OleDbDataAdapter(Select, DataConnection);

            try
            {
                //It then clears the datagridview and loads the data that has been selected from the DataAdapter.
                database1DataSet.tblReject_test.Clear();
                bdDataAdapter.Fill(this.database1DataSet.tblReject_test);
            }
            catch (OleDbException exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }
        }
    }
}
