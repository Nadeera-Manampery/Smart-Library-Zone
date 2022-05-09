namespace library_zone
{
    partial class ucbr_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucbr_help));
            this.btnFeedback = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnFeedback
            // 
            this.btnFeedback.ActiveControl = null;
            this.btnFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnFeedback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFeedback.Location = new System.Drawing.Point(128, 235);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(451, 108);
            this.btnFeedback.TabIndex = 15;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFeedback.UseCustomBackColor = true;
            this.btnFeedback.UseCustomForeColor = true;
            this.btnFeedback.UseMnemonic = false;
            this.btnFeedback.UseSelectable = true;
            this.btnFeedback.UseStyleColors = true;
            this.btnFeedback.UseTileImage = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.metroTile1.Location = new System.Drawing.Point(0, 639);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1000, 11);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // ucbr_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnFeedback);
            this.Name = "ucbr_help";
            this.Size = new System.Drawing.Size(1000, 650);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnFeedback;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
