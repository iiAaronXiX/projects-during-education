using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RRAS
{

    public partial class formRRAS : Form
    {
        public OleDbConnection DataConnection = new OleDbConnection();

        string cmbRFR_item;

        public formRRAS()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        //When the form loads it sets the intial combo box RFR item to null
        private void formRRAS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.tblReject_test' table. You can move, or remove it, as needed.
            this.tblReject_testTableAdapter.Fill(this.database1DataSet.tblReject_test);

            cmbRFR.SelectedItem = "";

            this.AcceptButton = btnSearch;

        }

        //AddRFR method, called in the NewRFRPopup
        public void AddRFR(object item)
        {
            cmbRFR.Items.Add(item);
        }

        private void change_cmbSubRFR_items()
        {
            cmbSubRFR.Items.Clear();//Clear all items in cmbSubRFR comboBox.
            switch (cmbRFR_item)//Adding your new items to cmbSubRFR.
            {
                case "":
                    cmbSubRFR.Items.Add("");
                    cmbSubRFR.Text = "";
                    break;
                case "POSITIONING":
                    cmbSubRFR.Items.Add("");
                    cmbSubRFR.Items.Add("Anatomy cut-off");
                    cmbSubRFR.Items.Add("Rotation");
                    cmbSubRFR.Items.Add("Obstructed view");
                    cmbSubRFR.Items.Add("Tube or grid centering");
                    cmbSubRFR.Items.Add("Motion");
                    cmbSubRFR.Text = "";
                    break;
                case "ARTEFACT":
                    cmbSubRFR.Items.Add("");
                    cmbSubRFR.Items.Add("ARTEFACT");
                    cmbSubRFR.Text = "ARTEFACT";
                    cmbSubRFR.Text = "";
                    break;
                case "PATIENT ID":
                    cmbSubRFR.Items.Add("");
                    cmbSubRFR.Items.Add("Incorrect Patient");
                    cmbSubRFR.Items.Add("Incorrect Study/Side");
                    cmbSubRFR.Items.Add("User Defined Error");
                    cmbSubRFR.Text = "";
                    break;
                case "EXPOSURE ERROR":
                    cmbSubRFR.Items.Add("");
                    cmbSubRFR.Items.Add("Under Exposure");
                    cmbSubRFR.Items.Add("Over Exposure");
                    cmbSubRFR.Items.Add("Exposure Malfunction");
                    cmbSubRFR.Text = "";
                    break;
                case "TEST IMAGES":
                    cmbSubRFR.Items.Add("");
                    cmbSubRFR.Items.Add("Quality Control");
                    cmbSubRFR.Items.Add("Service/Test");
                    cmbSubRFR.Text = "";
                    break;
            }
        }
        private void cmbRFR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRFR_item != cmbRFR.SelectedItem.ToString())//This controls the changes in cmbRFR about selected item and call change_cmbSubRFR_items()
            {
                cmbRFR_item = cmbRFR.SelectedItem.ToString();
                change_cmbSubRFR_items();
            }
        }

        //The code for the button that closes the application

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //This creates the String Publisher which grabs the information from the combo box on the form.
            //Select and Dataconnection are also defined here.
            string Department = String.IsNullOrEmpty(txtDepartment.Text) ? "%" : txtDepartment.Text;
            string Start_Date = String.IsNullOrEmpty(txtStart.Text) ? "%" : txtStart.Text;
            string End_Date = String.IsNullOrEmpty(txtEnd.Text) ? "%" : txtEnd.Text;
            string Anatomy = String.IsNullOrEmpty(txtAnatomy.Text) ? "%" : txtAnatomy.Text;
            string RFR = String.IsNullOrEmpty(cmbRFR.Text) ? "%" : cmbRFR.Text;
            string Comment = String.IsNullOrEmpty(cmbSubRFR.Text) ? "%" : cmbSubRFR.Text;
            
            string Select = "SELECT * FROM tblReject_test WHERE department_id LIKE '" + Department + "'" + "AND body_part_examined LIKE'" + Anatomy + "'" + "AND study_date LIKE'" + Start_Date + "'" + "AND study_date LIKE'" + End_Date + "'" + "AND reject_category LIKE'" + RFR + "'" + "AND reject_comment LIKE'" + Comment + "'";


            //DataConnection connects to the database.
            string connectiontring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
            DataConnection = new OleDbConnection(connectiontring);

            //The DataAdapter is the code that ensures both the data in the Select and DataConnection strings match.
            OleDbDataAdapter rdDataAdapter = new OleDbDataAdapter(Select, DataConnection);

            try
            {
                //It then clears the datagridview and loads the data that has been selected from the DataAdapter.
                database1DataSet.tblReject_test.Clear();
                rdDataAdapter.Fill(this.database1DataSet.tblReject_test);
            }
            catch (OleDbException exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

        } //End of Search button

        //Temporary button thats loads the chart when clicked
        private void btnAllDepartments_Click(object sender, EventArgs e)
        {
            charRejections.Series["RFR"].Points.Clear();
            charRejections.Series["RFR"].Enabled = true;
            {
                string connectiontring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
                DataConnection = new OleDbConnection(connectiontring);

                try
                {

                    DataConnection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DataConnection;
                    string query = "SELECT COUNT(reject_category) as reject, reject_category FROM tblReject_test GROUP BY reject_category";
                    command.CommandText = query;


                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        charRejections.Series["RFR"].Points.AddXY(reader["reject_category"].ToString(), reader["reject"].ToString());
                    }

                    DataConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            } 
        }//end of All Departments button

        private void btnBodyParts_Click(object sender, EventArgs e)
        {
            charRejections.Series["RFR"].Points.Clear();
            charRejections.Series["RFR"].Enabled = true;
            {
                string connectiontring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
                DataConnection = new OleDbConnection(connectiontring);

                try
                {

                    DataConnection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DataConnection;
                    string query = "SELECT COUNT(body_part_examined) as reject, body_part_examined FROM tblReject_test GROUP BY body_part_examined";
                    command.CommandText = query;


                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        charRejections.Series["RFR"].Points.AddXY(reader["body_part_examined"].ToString(), reader["reject"].ToString());
                    }

                    DataConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            } 
        }//end of Body Parts Examined button

        private void btnDept1_Click(object sender, EventArgs e)
        {
            charRejections.Series["RFR"].Points.Clear();
            charRejections.Series["RFR"].Enabled = true;
            {
                string connectiontring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
                DataConnection = new OleDbConnection(connectiontring);

                try
                {

                    DataConnection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DataConnection;
                    string query = "SELECT COUNT(reject_category) as reject, reject_category FROM tblReject_test WHERE department_id = '1' GROUP BY reject_category";
                    command.CommandText = query;


                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        charRejections.Series["RFR"].Points.AddXY(reader["reject_category"].ToString(), reader["reject"].ToString());
                    }

                    DataConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }// end of Dept 1 button


        private void btnDept2_Click(object sender, EventArgs e)
        {
            charRejections.Series["RFR"].Points.Clear();
            charRejections.Series["RFR"].Enabled = true;
            {
                string connectiontring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
                DataConnection = new OleDbConnection(connectiontring);

                try
                {

                    DataConnection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DataConnection;
                    string query = "SELECT COUNT(reject_category) as reject, reject_category FROM tblReject_test WHERE department_id = '2' GROUP BY reject_category";
                    command.CommandText = query;


                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        charRejections.Series["RFR"].Points.AddXY(reader["reject_category"].ToString(), reader["reject"].ToString());
                    }

                    DataConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        private void btnDept3_Click(object sender, EventArgs e)
        {
            charRejections.Series["RFR"].Points.Clear();
            charRejections.Series["RFR"].Enabled = true;

            charRejections.Series["Department 1"].Points.Clear();
            charRejections.Series["Department 1"].Enabled = false;

            charRejections.Series["Department 2"].Points.Clear();
            charRejections.Series["Department 2"].Enabled = false;

            charRejections.Series["Department 3"].Points.Clear();
            charRejections.Series["Department 3"].Enabled = false;
            {
                string connectiontring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
                DataConnection = new OleDbConnection(connectiontring);

                try
                {

                    DataConnection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DataConnection;
                    string query = "SELECT COUNT(reject_category) as reject, reject_category FROM tblReject_test WHERE department_id = '3' GROUP BY reject_category";
                    command.CommandText = query;


                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        charRejections.Series["RFR"].Points.AddXY(reader["reject_category"].ToString(), reader["reject"].ToString());
                    }

                    DataConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }
        }

        //These buttons are all from the file menu bar
        //A simple button that closes the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void videoTutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVideoTutorial video = new frmVideoTutorial(this);
            video.ShowDialog();
        }

        //This button loads the NewRFRPopup form
        private void addRFRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRFRPopup popup = new NewRFRPopup(this);
            popup.ShowDialog();
        }

        //This button opens up a file browser, allowing the user to search for the tab delimited text file
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectiontring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database1.mdb";
            DataConnection = new OleDbConnection(connectiontring);
            DataConnection.Open();

            Stream myStream = null;

            ofd.Title = "Select Text File";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Text Files (.txt) |*.txt";
            ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader reader = new System.IO.StreamReader(myStream);
                            string text = reader.ReadLine(); //code to read each line word by word and divide it up//
                            string[] row = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (string c in row)
                            {
                                string[] rejects = c.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                                string Column1 = rejects[0];
                                string Column2 = rejects[1];
                                string Column3 = rejects[2];
                                string Column4 = rejects[3];
                                string Column5 = rejects[4];
                                string Column6 = rejects[5];
                                string Column7 = rejects[6];
                                string Column8 = rejects[7];
                                string Column9 = rejects[8];
                                string Column10 = rejects[9];
                                string Column11 = rejects[10];
                                string Column12 = rejects[11];
                                string Column13 = rejects[12];
                                string Column14 = rejects[13];
                                string Column15 = rejects[14];
                                string Column16 = rejects[15];
                                string Column17 = rejects[16];
                                string Column18 = rejects[17];
                                string Column19 = rejects[18];
                                string Column20 = rejects[19];
                                string Column21 = rejects[20];
                                string Column22 = rejects[21];
                                string Column23 = rejects[22];
                                string Column24 = rejects[23];
                                string Column25 = rejects[24];
                                string Column26 = rejects[25];
                                string Column27 = rejects[26];
                                string Column28 = rejects[27];
                                string Column29 = rejects[28];
                                string Column30 = rejects[29];

                                try
                                {
                                    string Column31 = "1";
                                    string Insert = "INSERT INTO tblReject_test (sop_instance_uid, study_instance_uid, accession_number, patient_id, patient_name, date_of_birth, sex, study_date, study_time, mpm_code, body_part_examined, ank_menu_name, kanji_menu_name, s_value, l_value, ip_number, fcr_image_id, technologist, requesting_department, Kanji_requesting_department, size_code, film_mark1, film_mark2, status, technologist_code, ip_number2, reject_category, reject_comment, code, reject_image, department_id) VALUES ('" + Column1 + "," + Column2 + "," + Column3 + "," + Column4 + "," + Column5 + "," + Column6 + "," + Column7 + "," + Column8 + "," + Column9 + "," + Column10 + "," + Column11 + "," + Column12 + "," + Column13 + "," + Column14 + "," + Column15 + "," + Column16 + "," + Column17 + "," + Column18 + "," + Column19 + "," + Column20 + "," + Column21 + "," + Column22 + "," + Column23 + "," + Column24 + "," + Column25 + "," + Column26 + "," + Column27 + "," + Column28 + "," + Column29 + "," + Column30 + "," + Column31 + "')";

                                    //database connection to execute insert command
                                    OleDbCommand cmd = new OleDbCommand(Insert, DataConnection);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("File has been uploaded.", "Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                   
                                    DataConnection.Close();

                                    database1DataSet.tblReject_test.Clear();
                                    this.tblReject_testTableAdapter.Fill(this.database1DataSet.tblReject_test);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                                }
                            }
                        }
                    }
                }
            }

                
        //This button allows the user to print off the chart they are currently viewing
        private void printChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            charRejections.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
            charRejections.Printing.PrintPreview();
        }

        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserGuide ugPopup = new UserGuide(this);
            ugPopup.ShowDialog();
        }
        //End of file menu bar


        //These buttons change the format of the chart
        private void btnPie_Click(object sender, EventArgs e)
        {
            charRejections.Series["RFR"].Enabled = true;

            this.charRejections.Series["RFR"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            charRejections.Series["RFR"].Enabled = true;

            this.charRejections.Series["RFR"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }
        //end of chart formatting
    }
}

