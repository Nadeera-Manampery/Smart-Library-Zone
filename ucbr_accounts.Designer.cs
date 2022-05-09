namespace library_zone
{
    partial class ucbr_accounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucbr_accounts));
            this.btnUpOfficer = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateMmember = new MetroFramework.Controls.MetroTile();
            this.btnUpdateProfile = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpOfficer
            // 
            this.btnUpOfficer.ActiveControl = null;
            this.btnUpOfficer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpOfficer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnUpOfficer.Location = new System.Drawing.Point(147, 221);
            this.btnUpOfficer.Name = "btnUpOfficer";
            this.btnUpOfficer.Size = new System.Drawing.Size(605, 165);
            this.btnUpOfficer.TabIndex = 15;
            this.btnUpOfficer.Text = "Update Officer Account";
            this.btnUpOfficer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpOfficer.UseCustomBackColor = true;
            this.btnUpOfficer.UseSelectable = true;
            this.btnUpOfficer.UseStyleColors = true;
            this.btnUpOfficer.Click += new System.EventHandler(this.btnUpOfficer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateMmember
            // 
            this.btnUpdateMmember.ActiveControl = null;
            this.btnUpdateMmember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateMmember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnUpdateMmember.Location = new System.Drawing.Point(402, 50);
            this.btnUpdateMmember.Name = "btnUpdateMmember";
            this.btnUpdateMmember.Size = new System.Drawing.Size(350, 165);
            this.btnUpdateMmember.TabIndex = 14;
            this.btnUpdateMmember.Text = "Update Member Profile";
            this.btnUpdateMmember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateMmember.UseCustomBackColor = true;
            this.btnUpdateMmember.UseSelectable = true;
            this.btnUpdateMmember.Click += new System.EventHandler(this.btnUpdateMmember_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.ActiveControl = null;
            this.btnUpdateProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnUpdateProfile.Location = new System.Drawing.Point(147, 50);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(249, 165);
            this.btnUpdateProfile.TabIndex = 13;
            this.btnUpdateProfile.Text = "Update Your Profile";
            this.btnUpdateProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateProfile.UseCustomBackColor = true;
            this.btnUpdateProfile.UseSelectable = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.metroTile1.Location = new System.Drawing.Point(0, 639);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1000, 11);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // ucbr_accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnUpOfficer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdateMmember);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.metroTile1);
            this.Name = "ucbr_accounts";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnUpOfficer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnUpdateMmember;
        private MetroFramework.Controls.MetroTile btnUpdateProfile;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
