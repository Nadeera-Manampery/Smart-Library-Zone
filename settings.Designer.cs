namespace library_zone
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnQr = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFeedback = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.metroTile1.Location = new System.Drawing.Point(0, 639);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1000, 11);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // btnQr
            // 
            this.btnQr.ActiveControl = null;
            this.btnQr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnQr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQr.Location = new System.Drawing.Point(222, 159);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(307, 108);
            this.btnQr.TabIndex = 4;
            this.btnQr.Text = "QR For Employers";
            this.btnQr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQr.UseCustomBackColor = true;
            this.btnQr.UseCustomForeColor = true;
            this.btnQr.UseMnemonic = false;
            this.btnQr.UseSelectable = true;
            this.btnQr.UseStyleColors = true;
            this.btnQr.UseTileImage = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 608);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnFeedback
            // 
            this.btnFeedback.ActiveControl = null;
            this.btnFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnFeedback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFeedback.Location = new System.Drawing.Point(222, 273);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(307, 108);
            this.btnFeedback.TabIndex = 11;
            this.btnFeedback.Text = "Feedbacks";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFeedback.UseCustomBackColor = true;
            this.btnFeedback.UseCustomForeColor = true;
            this.btnFeedback.UseMnemonic = false;
            this.btnFeedback.UseSelectable = true;
            this.btnFeedback.UseStyleColors = true;
            this.btnFeedback.UseTileImage = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnQr);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "settings";
            this.Size = new System.Drawing.Size(1000, 650);
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile btnQr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnFeedback;
    }
}
