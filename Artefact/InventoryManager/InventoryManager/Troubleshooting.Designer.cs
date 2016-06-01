namespace InventoryManager
{
    partial class frmTrouble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrouble));
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtUserDetails = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnOverview = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(509, 66);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 23);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtUserDetails
            // 
            this.txtUserDetails.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserDetails.Location = new System.Drawing.Point(398, 12);
            this.txtUserDetails.Multiline = true;
            this.txtUserDetails.Name = "txtUserDetails";
            this.txtUserDetails.ReadOnly = true;
            this.txtUserDetails.Size = new System.Drawing.Size(203, 48);
            this.txtUserDetails.TabIndex = 22;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::InventoryManager.Properties.Resources.EntertainerLogo;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(342, 80);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 21;
            this.pbLogo.TabStop = false;
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.Location = new System.Drawing.Point(398, 66);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(92, 23);
            this.btnOverview.TabIndex = 32;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 359);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.SystemColors.Window;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(405, 36);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(12, 18);
            this.lblUserID.TabIndex = 35;
            this.lblUserID.Text = " ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Window;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(405, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(12, 18);
            this.lblName.TabIndex = 34;
            this.lblName.Text = " ";
            // 
            // frmTrouble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(612, 480);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtUserDetails);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmTrouble";
            this.Text = "Troubleshooting";
            this.Load += new System.EventHandler(this.frmTrouble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtUserDetails;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblName;
    }
}