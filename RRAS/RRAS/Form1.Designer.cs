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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuFileToolbar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabConRejQA = new System.Windows.Forms.TabControl();
            this.tabRejections = new System.Windows.Forms.TabPage();
            this.gridViewRejections = new System.Windows.Forms.DataGridView();
            this.btnSideways = new System.Windows.Forms.Button();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.charRejections = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabQA = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gridViewQA = new System.Windows.Forms.DataGridView();
            this.charQA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTrademark = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnatomy = new System.Windows.Forms.TextBox();
            this.cmbRFR = new System.Windows.Forms.ComboBox();
            this.database1DataSet = new RRAS.Database1DataSet();
            this.tblRejecttestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblReject_testTableAdapter = new RRAS.Database1DataSetTableAdapters.tblReject_testTableAdapter();
            this.bodypartexaminedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejectcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestingdepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ankmenunameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmmark1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmmark2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuFileToolbar.SuspendLayout();
            this.tabConRejQA.SuspendLayout();
            this.tabRejections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRejections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charRejections)).BeginInit();
            this.tabQA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charQA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRejecttestBindingSource)).BeginInit();
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
            this.menuFileToolbar.Size = new System.Drawing.Size(873, 24);
            this.menuFileToolbar.TabIndex = 0;
            this.menuFileToolbar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
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
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabConRejQA
            // 
            this.tabConRejQA.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabConRejQA.Controls.Add(this.tabRejections);
            this.tabConRejQA.Controls.Add(this.tabQA);
            this.tabConRejQA.Location = new System.Drawing.Point(0, 90);
            this.tabConRejQA.Multiline = true;
            this.tabConRejQA.Name = "tabConRejQA";
            this.tabConRejQA.SelectedIndex = 0;
            this.tabConRejQA.Size = new System.Drawing.Size(874, 568);
            this.tabConRejQA.TabIndex = 1;
            // 
            // tabRejections
            // 
            this.tabRejections.Controls.Add(this.gridViewRejections);
            this.tabRejections.Controls.Add(this.btnSideways);
            this.tabRejections.Controls.Add(this.btnBar);
            this.tabRejections.Controls.Add(this.btnLine);
            this.tabRejections.Controls.Add(this.btnPie);
            this.tabRejections.Controls.Add(this.charRejections);
            this.tabRejections.Location = new System.Drawing.Point(23, 4);
            this.tabRejections.Name = "tabRejections";
            this.tabRejections.Padding = new System.Windows.Forms.Padding(3);
            this.tabRejections.Size = new System.Drawing.Size(847, 560);
            this.tabRejections.TabIndex = 0;
            this.tabRejections.Text = "Rejections";
            this.tabRejections.UseVisualStyleBackColor = true;
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
            this.gridViewRejections.Size = new System.Drawing.Size(846, 288);
            this.gridViewRejections.TabIndex = 8;
            // 
            // btnSideways
            // 
            this.btnSideways.Location = new System.Drawing.Point(731, 131);
            this.btnSideways.Name = "btnSideways";
            this.btnSideways.Size = new System.Drawing.Size(45, 39);
            this.btnSideways.TabIndex = 7;
            this.btnSideways.Text = "Sideways Bar Chart";
            this.btnSideways.UseVisualStyleBackColor = true;
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(782, 131);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(45, 39);
            this.btnBar.TabIndex = 6;
            this.btnBar.Text = "Bar Chart";
            this.btnBar.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(782, 86);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(45, 39);
            this.btnLine.TabIndex = 5;
            this.btnLine.Text = "Line Graph";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(731, 86);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(45, 39);
            this.btnPie.TabIndex = 2;
            this.btnPie.Text = "Pie Chart";
            this.btnPie.UseVisualStyleBackColor = true;
            // 
            // charRejections
            // 
            chartArea3.Name = "ChartArea1";
            this.charRejections.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.charRejections.Legends.Add(legend3);
            this.charRejections.Location = new System.Drawing.Point(0, 0);
            this.charRejections.Name = "charRejections";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.charRejections.Series.Add(series3);
            this.charRejections.Size = new System.Drawing.Size(714, 272);
            this.charRejections.TabIndex = 0;
            this.charRejections.Text = "chart1";
            // 
            // tabQA
            // 
            this.tabQA.Controls.Add(this.btnUpdate);
            this.tabQA.Controls.Add(this.gridViewQA);
            this.tabQA.Controls.Add(this.charQA);
            this.tabQA.Location = new System.Drawing.Point(23, 4);
            this.tabQA.Name = "tabQA";
            this.tabQA.Padding = new System.Windows.Forms.Padding(3);
            this.tabQA.Size = new System.Drawing.Size(847, 560);
            this.tabQA.TabIndex = 1;
            this.tabQA.Text = "QA";
            this.tabQA.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(750, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // gridViewQA
            // 
            this.gridViewQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewQA.Location = new System.Drawing.Point(0, 272);
            this.gridViewQA.Name = "gridViewQA";
            this.gridViewQA.Size = new System.Drawing.Size(847, 288);
            this.gridViewQA.TabIndex = 10;
            // 
            // charQA
            // 
            chartArea4.Name = "ChartArea1";
            this.charQA.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.charQA.Legends.Add(legend4);
            this.charQA.Location = new System.Drawing.Point(0, 0);
            this.charQA.Name = "charQA";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.charQA.Series.Add(series4);
            this.charQA.Size = new System.Drawing.Size(725, 272);
            this.charQA.TabIndex = 9;
            this.charQA.Text = "chart2";
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
            this.txtDepartment.Location = new System.Drawing.Point(168, 39);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start Date";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(347, 38);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 17;
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
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(515, 37);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 19;
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
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(515, 63);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(100, 20);
            this.txtComment.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "RFR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Anatomy";
            // 
            // txtAnatomy
            // 
            this.txtAnatomy.Location = new System.Drawing.Point(168, 65);
            this.txtAnatomy.Name = "txtAnatomy";
            this.txtAnatomy.Size = new System.Drawing.Size(100, 20);
            this.txtAnatomy.TabIndex = 21;
            // 
            // cmbRFR
            // 
            this.cmbRFR.DisplayMember = "reject_comment";
            this.cmbRFR.FormattingEnabled = true;
            this.cmbRFR.Location = new System.Drawing.Point(347, 62);
            this.cmbRFR.Name = "cmbRFR";
            this.cmbRFR.Size = new System.Drawing.Size(100, 21);
            this.cmbRFR.TabIndex = 27;
            this.cmbRFR.ValueMember = "reject_comment";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRejecttestBindingSource
            // 
            this.tblRejecttestBindingSource.DataMember = "tblReject_test";
            this.tblRejecttestBindingSource.DataSource = this.database1DataSet;
            // 
            // tblReject_testTableAdapter
            // 
            this.tblReject_testTableAdapter.ClearBeforeFill = true;
            // 
            // bodypartexaminedDataGridViewTextBoxColumn
            // 
            this.bodypartexaminedDataGridViewTextBoxColumn.DataPropertyName = "body_part_examined";
            this.bodypartexaminedDataGridViewTextBoxColumn.HeaderText = "body_part_examined";
            this.bodypartexaminedDataGridViewTextBoxColumn.Name = "bodypartexaminedDataGridViewTextBoxColumn";
            // 
            // rejectcategoryDataGridViewTextBoxColumn
            // 
            this.rejectcategoryDataGridViewTextBoxColumn.DataPropertyName = "reject_category";
            this.rejectcategoryDataGridViewTextBoxColumn.HeaderText = "reject_category";
            this.rejectcategoryDataGridViewTextBoxColumn.Name = "rejectcategoryDataGridViewTextBoxColumn";
            // 
            // rejectcommentDataGridViewTextBoxColumn
            // 
            this.rejectcommentDataGridViewTextBoxColumn.DataPropertyName = "reject_comment";
            this.rejectcommentDataGridViewTextBoxColumn.HeaderText = "reject_comment";
            this.rejectcommentDataGridViewTextBoxColumn.Name = "rejectcommentDataGridViewTextBoxColumn";
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // requestingdepartmentDataGridViewTextBoxColumn
            // 
            this.requestingdepartmentDataGridViewTextBoxColumn.DataPropertyName = "requesting_department";
            this.requestingdepartmentDataGridViewTextBoxColumn.HeaderText = "requesting_department";
            this.requestingdepartmentDataGridViewTextBoxColumn.Name = "requestingdepartmentDataGridViewTextBoxColumn";
            // 
            // ankmenunameDataGridViewTextBoxColumn
            // 
            this.ankmenunameDataGridViewTextBoxColumn.DataPropertyName = "ank_menu_name";
            this.ankmenunameDataGridViewTextBoxColumn.HeaderText = "ank_menu_name";
            this.ankmenunameDataGridViewTextBoxColumn.Name = "ankmenunameDataGridViewTextBoxColumn";
            // 
            // filmmark1DataGridViewTextBoxColumn
            // 
            this.filmmark1DataGridViewTextBoxColumn.DataPropertyName = "film_mark1";
            this.filmmark1DataGridViewTextBoxColumn.HeaderText = "film_mark1";
            this.filmmark1DataGridViewTextBoxColumn.Name = "filmmark1DataGridViewTextBoxColumn";
            // 
            // filmmark2DataGridViewTextBoxColumn
            // 
            this.filmmark2DataGridViewTextBoxColumn.DataPropertyName = "film_mark2";
            this.filmmark2DataGridViewTextBoxColumn.HeaderText = "film_mark2";
            this.filmmark2DataGridViewTextBoxColumn.Name = "filmmark2DataGridViewTextBoxColumn";
            // 
            // formRRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 676);
            this.Controls.Add(this.cmbRFR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnatomy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStart);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRejections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charRejections)).EndInit();
            this.tabQA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charQA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRejecttestBindingSource)).EndInit();
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
        private System.Windows.Forms.TabPage tabQA;
        private System.Windows.Forms.DataGridView gridViewRejections;
        private System.Windows.Forms.Button btnSideways;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.DataGridView gridViewQA;
        private System.Windows.Forms.DataVisualization.Charting.Chart charQA;
        private System.Windows.Forms.Label lblTrademark;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnatomy;
        private System.Windows.Forms.ComboBox cmbRFR;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tblRejecttestBindingSource;
        private Database1DataSetTableAdapters.tblReject_testTableAdapter tblReject_testTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodypartexaminedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejectcommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestingdepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ankmenunameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmmark1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmmark2DataGridViewTextBoxColumn;
    }
}

