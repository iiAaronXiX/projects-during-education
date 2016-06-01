namespace RRAS
{
    partial class formRRAS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuFileToolbar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRFRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoTutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabConRejQA = new System.Windows.Forms.TabControl();
            this.tabRejections = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDept1 = new System.Windows.Forms.Button();
            this.btnDept3 = new System.Windows.Forms.Button();
            this.btnAllDepartments = new System.Windows.Forms.Button();
            this.btnDept2 = new System.Windows.Forms.Button();
            this.btnBodyParts = new System.Windows.Forms.Button();
            this.gridViewRejections = new System.Windows.Forms.DataGridView();
            this.bodypartexaminedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestingdepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankmenunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmmark1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmmark2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRejecttestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new RRAS.Database1DataSet();
            this.charRejections = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTrademark = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnatomy = new System.Windows.Forms.TextBox();
            this.tblReject_testTableAdapter = new RRAS.Database1DataSetTableAdapters.tblReject_testTableAdapter();
            this.cmbRFR = new System.Windows.Forms.ComboBox();
            this.cmbSubRFR = new System.Windows.Forms.ComboBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.menuFileToolbar.SuspendLayout();
            this.tabConRejQA.SuspendLayout();
            this.tabRejections.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRejections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRejecttestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charRejections)).BeginInit();
            this.SuspendLayout();
            // 
            // menuFileToolbar
            // 
            this.menuFileToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.uploadToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuFileToolbar.Location = new System.Drawing.Point(0, 0);
            this.menuFileToolbar.Name = "menuFileToolbar";
            this.menuFileToolbar.Size = new System.Drawing.Size(871, 24);
            this.menuFileToolbar.TabIndex = 0;
            this.menuFileToolbar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printChartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printChartToolStripMenuItem
            // 
            this.printChartToolStripMenuItem.Name = "printChartToolStripMenuItem";
            this.printChartToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.printChartToolStripMenuItem.Text = "Print Chart";
            this.printChartToolStripMenuItem.Click += new System.EventHandler(this.printChartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem});
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.uploadToolStripMenuItem.Text = "Upload";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.newFileToolStripMenuItem.Text = "New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRFRToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addRFRToolStripMenuItem
            // 
            this.addRFRToolStripMenuItem.Name = "addRFRToolStripMenuItem";
            this.addRFRToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.addRFRToolStripMenuItem.Text = "Alternate RFR";
            this.addRFRToolStripMenuItem.Click += new System.EventHandler(this.addRFRToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGuideToolStripMenuItem,
            this.videoTutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            this.userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            this.userGuideToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.userGuideToolStripMenuItem.Text = "User Guide";
            this.userGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // videoTutorialToolStripMenuItem
            // 
            this.videoTutorialToolStripMenuItem.Name = "videoTutorialToolStripMenuItem";
            this.videoTutorialToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.videoTutorialToolStripMenuItem.Text = "Video Tutorial";
            this.videoTutorialToolStripMenuItem.Click += new System.EventHandler(this.videoTutorialToolStripMenuItem_Click);
            // 
            // tabConRejQA
            // 
            this.tabConRejQA.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabConRejQA.Controls.Add(this.tabRejections);
            this.tabConRejQA.Location = new System.Drawing.Point(0, 90);
            this.tabConRejQA.Multiline = true;
            this.tabConRejQA.Name = "tabConRejQA";
            this.tabConRejQA.SelectedIndex = 0;
            this.tabConRejQA.Size = new System.Drawing.Size(874, 568);
            this.tabConRejQA.TabIndex = 1;
            // 
            // tabRejections
            // 
            this.tabRejections.Controls.Add(this.groupBox2);
            this.tabRejections.Controls.Add(this.groupBox1);
            this.tabRejections.Controls.Add(this.btnBodyParts);
            this.tabRejections.Controls.Add(this.gridViewRejections);
            this.tabRejections.Controls.Add(this.charRejections);
            this.tabRejections.Location = new System.Drawing.Point(23, 4);
            this.tabRejections.Name = "tabRejections";
            this.tabRejections.Padding = new System.Windows.Forms.Padding(3);
            this.tabRejections.Size = new System.Drawing.Size(847, 560);
            this.tabRejections.TabIndex = 0;
            this.tabRejections.Text = "Rejections";
            this.tabRejections.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPie);
            this.groupBox2.Controls.Add(this.btnBar);
            this.groupBox2.Location = new System.Drawing.Point(684, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 65);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart Type";
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(30, 19);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(45, 39);
            this.btnPie.TabIndex = 2;
            this.btnPie.Text = "Pie Chart";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(81, 19);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(45, 39);
            this.btnBar.TabIndex = 6;
            this.btnBar.Text = "Bar Chart";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDept1);
            this.groupBox1.Controls.Add(this.btnDept3);
            this.groupBox1.Controls.Add(this.btnAllDepartments);
            this.groupBox1.Controls.Add(this.btnDept2);
            this.groupBox1.Location = new System.Drawing.Point(684, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 93);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // btnDept1
            // 
            this.btnDept1.Location = new System.Drawing.Point(6, 15);
            this.btnDept1.Name = "btnDept1";
            this.btnDept1.Size = new System.Drawing.Size(45, 39);
            this.btnDept1.TabIndex = 11;
            this.btnDept1.Text = "Dept 1";
            this.btnDept1.UseVisualStyleBackColor = true;
            this.btnDept1.Click += new System.EventHandler(this.btnDept1_Click);
            // 
            // btnDept3
            // 
            this.btnDept3.Location = new System.Drawing.Point(108, 15);
            this.btnDept3.Name = "btnDept3";
            this.btnDept3.Size = new System.Drawing.Size(45, 39);
            this.btnDept3.TabIndex = 13;
            this.btnDept3.Text = "Dept 3";
            this.btnDept3.UseVisualStyleBackColor = true;
            this.btnDept3.Click += new System.EventHandler(this.btnDept3_Click);
            // 
            // btnAllDepartments
            // 
            this.btnAllDepartments.Location = new System.Drawing.Point(6, 60);
            this.btnAllDepartments.Name = "btnAllDepartments";
            this.btnAllDepartments.Size = new System.Drawing.Size(146, 27);
            this.btnAllDepartments.TabIndex = 9;
            this.btnAllDepartments.Text = "All Departments";
            this.btnAllDepartments.UseVisualStyleBackColor = true;
            this.btnAllDepartments.Click += new System.EventHandler(this.btnAllDepartments_Click);
            // 
            // btnDept2
            // 
            this.btnDept2.Location = new System.Drawing.Point(57, 15);
            this.btnDept2.Name = "btnDept2";
            this.btnDept2.Size = new System.Drawing.Size(45, 39);
            this.btnDept2.TabIndex = 12;
            this.btnDept2.Text = "Dept 2";
            this.btnDept2.UseVisualStyleBackColor = true;
            this.btnDept2.Click += new System.EventHandler(this.btnDept2_Click);
            // 
            // btnBodyParts
            // 
            this.btnBodyParts.Location = new System.Drawing.Point(719, 116);
            this.btnBodyParts.Name = "btnBodyParts";
            this.btnBodyParts.Size = new System.Drawing.Size(87, 41);
            this.btnBodyParts.TabIndex = 10;
            this.btnBodyParts.Text = "Body Parts Examined";
            this.btnBodyParts.UseVisualStyleBackColor = true;
            this.btnBodyParts.Click += new System.EventHandler(this.btnBodyParts_Click);
            // 
            // gridViewRejections
            // 
            this.gridViewRejections.AutoGenerateColumns = false;
            this.gridViewRejections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRejections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bodypartexaminedDataGridViewTextBoxColumn,
            this.rejectcategoryDataGridViewTextBoxColumn,
            this.rejectcommentDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.requestingdepartmentDataGridViewTextBoxColumn,
            this.ankmenunameDataGridViewTextBoxColumn,
            this.filmmark1DataGridViewTextBoxColumn,
            this.filmmark2DataGridViewTextBoxColumn});
            this.gridViewRejections.DataSource = this.tblRejecttestBindingSource;
            this.gridViewRejections.Location = new System.Drawing.Point(0, 272);
            this.gridViewRejections.Name = "gridViewRejections";
            this.gridViewRejections.ReadOnly = true;
            this.gridViewRejections.Size = new System.Drawing.Size(846, 288);
            this.gridViewRejections.TabIndex = 8;
            // 
            // bodypartexaminedDataGridViewTextBoxColumn
            // 
            this.bodypartexaminedDataGridViewTextBoxColumn.DataPropertyName = "body_part_examined";
            this.bodypartexaminedDataGridViewTextBoxColumn.HeaderText = "body_part_examined";
            this.bodypartexaminedDataGridViewTextBoxColumn.Name = "bodypartexaminedDataGridViewTextBoxColumn";
            this.bodypartexaminedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rejectcategoryDataGridViewTextBoxColumn
            // 
            this.rejectcategoryDataGridViewTextBoxColumn.DataPropertyName = "reject_category";
            this.rejectcategoryDataGridViewTextBoxColumn.HeaderText = "reject_category";
            this.rejectcategoryDataGridViewTextBoxColumn.Name = "rejectcategoryDataGridViewTextBoxColumn";
            this.rejectcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rejectcommentDataGridViewTextBoxColumn
            // 
            this.rejectcommentDataGridViewTextBoxColumn.DataPropertyName = "reject_comment";
            this.rejectcommentDataGridViewTextBoxColumn.HeaderText = "reject_comment";
            this.rejectcommentDataGridViewTextBoxColumn.Name = "rejectcommentDataGridViewTextBoxColumn";
            this.rejectcommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            this.departmentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestingdepartmentDataGridViewTextBoxColumn
            // 
            this.requestingdepartmentDataGridViewTextBoxColumn.DataPropertyName = "requesting_department";
            this.requestingdepartmentDataGridViewTextBoxColumn.HeaderText = "requesting_department";
            this.requestingdepartmentDataGridViewTextBoxColumn.Name = "requestingdepartmentDataGridViewTextBoxColumn";
            this.requestingdepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ankmenunameDataGridViewTextBoxColumn
            // 
            this.ankmenunameDataGridViewTextBoxColumn.DataPropertyName = "ank_menu_name";
            this.ankmenunameDataGridViewTextBoxColumn.HeaderText = "ank_menu_name";
            this.ankmenunameDataGridViewTextBoxColumn.Name = "ankmenunameDataGridViewTextBoxColumn";
            this.ankmenunameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmmark1DataGridViewTextBoxColumn
            // 
            this.filmmark1DataGridViewTextBoxColumn.DataPropertyName = "film_mark1";
            this.filmmark1DataGridViewTextBoxColumn.HeaderText = "film_mark1";
            this.filmmark1DataGridViewTextBoxColumn.Name = "filmmark1DataGridViewTextBoxColumn";
            this.filmmark1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmmark2DataGridViewTextBoxColumn
            // 
            this.filmmark2DataGridViewTextBoxColumn.DataPropertyName = "film_mark2";
            this.filmmark2DataGridViewTextBoxColumn.HeaderText = "film_mark2";
            this.filmmark2DataGridViewTextBoxColumn.Name = "filmmark2DataGridViewTextBoxColumn";
            this.filmmark2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblRejecttestBindingSource
            // 
            this.tblRejecttestBindingSource.DataMember = "tblReject_test";
            this.tblRejecttestBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charRejections
            // 
            chartArea1.Name = "ChartArea1";
            this.charRejections.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charRejections.Legends.Add(legend1);
            this.charRejections.Location = new System.Drawing.Point(0, 0);
            this.charRejections.Name = "charRejections";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "RFR";
            series2.ChartArea = "ChartArea1";
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.Name = "Department 1";
            series3.ChartArea = "ChartArea1";
            series3.Enabled = false;
            series3.Legend = "Legend1";
            series3.Name = "Department 2";
            series4.ChartArea = "ChartArea1";
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.Name = "Department 3";
            this.charRejections.Series.Add(series1);
            this.charRejections.Series.Add(series2);
            this.charRejections.Series.Add(series3);
            this.charRejections.Series.Add(series4);
            this.charRejections.Size = new System.Drawing.Size(678, 272);
            this.charRejections.TabIndex = 0;
            this.charRejections.Text = "chart1";
            // 
            // lblTrademark
            // 
            this.lblTrademark.AutoSize = true;
            this.lblTrademark.Location = new System.Drawing.Point(-3, 661);
            this.lblTrademark.Name = "lblTrademark";
            this.lblTrademark.Size = new System.Drawing.Size(165, 13);
            this.lblTrademark.TabIndex = 9;
            this.lblTrademark.Text = "RRAS is a trademark of Group25.";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(673, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(171, 39);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Comment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "RFR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Anatomy";
            // 
            // txtAnatomy
            // 
            this.txtAnatomy.Location = new System.Drawing.Point(171, 65);
            this.txtAnatomy.Name = "txtAnatomy";
            this.txtAnatomy.Size = new System.Drawing.Size(100, 20);
            this.txtAnatomy.TabIndex = 21;
            // 
            // tblReject_testTableAdapter
            // 
            this.tblReject_testTableAdapter.ClearBeforeFill = true;
            // 
            // cmbRFR
            // 
            this.cmbRFR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblRejecttestBindingSource, "reject_category", true));
            this.cmbRFR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblRejecttestBindingSource, "reject_category", true));
            this.cmbRFR.FormattingEnabled = true;
            this.cmbRFR.Items.AddRange(new object[] {
            "",
            "POSITIONING",
            "ARTEFACT",
            "PATIENT ID",
            "EXPOSURE ERROR",
            "TEST IMAGES"});
            this.cmbRFR.Location = new System.Drawing.Point(339, 64);
            this.cmbRFR.Name = "cmbRFR";
            this.cmbRFR.Size = new System.Drawing.Size(108, 21);
            this.cmbRFR.TabIndex = 27;
            this.cmbRFR.SelectedIndexChanged += new System.EventHandler(this.cmbRFR_SelectedIndexChanged);
            // 
            // cmbSubRFR
            // 
            this.cmbSubRFR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblRejecttestBindingSource, "reject_comment", true));
            this.cmbSubRFR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblRejecttestBindingSource, "reject_comment", true));
            this.cmbSubRFR.FormattingEnabled = true;
            this.cmbSubRFR.Location = new System.Drawing.Point(515, 64);
            this.cmbSubRFR.Name = "cmbSubRFR";
            this.cmbSubRFR.Size = new System.Drawing.Size(106, 21);
            this.cmbSubRFR.TabIndex = 28;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(339, 38);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(108, 20);
            this.txtStart.TabIndex = 29;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(515, 38);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(106, 20);
            this.txtEnd.TabIndex = 30;
            // 
            // formRRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 676);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.cmbSubRFR);
            this.Controls.Add(this.cmbRFR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnatomy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTrademark);
            this.Controls.Add(this.tabConRejQA);
            this.Controls.Add(this.menuFileToolbar);
            this.MainMenuStrip = this.menuFileToolbar;
            this.Name = "formRRAS";
            this.Text = "RRAS";
            this.Load += new System.EventHandler(this.formRRAS_Load);
            this.menuFileToolbar.ResumeLayout(false);
            this.menuFileToolbar.PerformLayout();
            this.tabConRejQA.ResumeLayout(false);
            this.tabRejections.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRejections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRejecttestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charRejections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFileToolbar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabConRejQA;
        private System.Windows.Forms.TabPage tabRejections;
        private System.Windows.Forms.DataVisualization.Charting.Chart charRejections;
        private System.Windows.Forms.DataGridView gridViewRejections;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Label lblTrademark;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnatomy;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tblRejecttestBindingSource;
        private Database1DataSetTableAdapters.tblReject_testTableAdapter tblReject_testTableAdapter;
        private System.Windows.Forms.Button btnAllDepartments;
        private System.Windows.Forms.ToolStripMenuItem addRFRToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbRFR;
        private System.Windows.Forms.ComboBox cmbSubRFR;
        private System.Windows.Forms.ToolStripMenuItem printChartToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodypartexaminedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectcommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestingdepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankmenunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmmark1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmmark2DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnBodyParts;
        private System.Windows.Forms.Button btnDept3;
        private System.Windows.Forms.Button btnDept2;
        private System.Windows.Forms.Button btnDept1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem userGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoTutorialToolStripMenuItem;
    }
}

