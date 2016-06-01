namespace InventoryManager
{
    partial class frmOverview
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
            this.txtUserDetails = new System.Windows.Forms.TextBox();
            this.btnTrouble = new System.Windows.Forms.Button();
            this.btnMoveStock = new System.Windows.Forms.Button();
            this.btnAmendStock = new System.Windows.Forms.Button();
            this.btnStockFile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserDetails
            // 
            this.txtUserDetails.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserDetails.Location = new System.Drawing.Point(398, 12);
            this.txtUserDetails.Multiline = true;
            this.txtUserDetails.Name = "txtUserDetails";
            this.txtUserDetails.ReadOnly = true;
            this.txtUserDetails.Size = new System.Drawing.Size(203, 48);
            this.txtUserDetails.TabIndex = 15;
            // 
            // btnTrouble
            // 
            this.btnTrouble.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTrouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrouble.Location = new System.Drawing.Point(12, 335);
            this.btnTrouble.Name = "btnTrouble";
            this.btnTrouble.Size = new System.Drawing.Size(589, 73);
            this.btnTrouble.TabIndex = 13;
            this.btnTrouble.Text = "Troubleshooting";
            this.btnTrouble.UseVisualStyleBackColor = false;
            this.btnTrouble.Click += new System.EventHandler(this.btnTrouble_Click);
            // 
            // btnMoveStock
            // 
            this.btnMoveStock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMoveStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveStock.Location = new System.Drawing.Point(12, 256);
            this.btnMoveStock.Name = "btnMoveStock";
            this.btnMoveStock.Size = new System.Drawing.Size(589, 73);
            this.btnMoveStock.TabIndex = 12;
            this.btnMoveStock.Text = "Move Stock";
            this.btnMoveStock.UseVisualStyleBackColor = false;
            // 
            // btnAmendStock
            // 
            this.btnAmendStock.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAmendStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmendStock.Location = new System.Drawing.Point(12, 177);
            this.btnAmendStock.Name = "btnAmendStock";
            this.btnAmendStock.Size = new System.Drawing.Size(589, 73);
            this.btnAmendStock.TabIndex = 11;
            this.btnAmendStock.Text = "Amend Stock";
            this.btnAmendStock.UseVisualStyleBackColor = false;
            this.btnAmendStock.Click += new System.EventHandler(this.btnAmendStock_Click);
            // 
            // btnStockFile
            // 
            this.btnStockFile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStockFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockFile.Location = new System.Drawing.Point(12, 98);
            this.btnStockFile.Name = "btnStockFile";
            this.btnStockFile.Size = new System.Drawing.Size(589, 73);
            this.btnStockFile.TabIndex = 10;
            this.btnStockFile.Text = "Stock File";
            this.btnStockFile.UseVisualStyleBackColor = false;
            this.btnStockFile.Click += new System.EventHandler(this.btnStockFile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(509, 66);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 23);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox4.Image = global::InventoryManager.Properties.Resources.TroubleShootingIcon;
            this.pictureBox4.Location = new System.Drawing.Point(23, 343);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox3.Image = global::InventoryManager.Properties.Resources.MoveStockIcon;
            this.pictureBox3.Location = new System.Drawing.Point(23, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Image = global::InventoryManager.Properties.Resources.AmendStockIcon;
            this.pictureBox2.Location = new System.Drawing.Point(23, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Image = global::InventoryManager.Properties.Resources.StockFileIcon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::InventoryManager.Properties.Resources.EntertainerLogo;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(342, 80);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Window;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(404, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(12, 18);
            this.lblName.TabIndex = 21;
            this.lblName.Text = " ";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.SystemColors.Window;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(404, 35);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(12, 18);
            this.lblUserID.TabIndex = 22;
            this.lblUserID.Text = " ";
            // 
            // frmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(613, 415);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUserDetails);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnTrouble);
            this.Controls.Add(this.btnMoveStock);
            this.Controls.Add(this.btnAmendStock);
            this.Controls.Add(this.btnStockFile);
            this.Name = "frmOverview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.frmOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserDetails;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnTrouble;
        private System.Windows.Forms.Button btnMoveStock;
        private System.Windows.Forms.Button btnAmendStock;
        private System.Windows.Forms.Button btnStockFile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserID;
    }
}

