namespace library_zone
{
    partial class ucbr_ebooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucbr_ebooks));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnRemoveEBooks = new MetroFramework.Controls.MetroTile();
            this.btnAvailableEBooks = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // btnRemoveEBooks
            // 
            this.btnRemoveEBooks.ActiveControl = null;
            this.btnRemoveEBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveEBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnRemoveEBooks.Location = new System.Drawing.Point(100, 159);
            this.btnRemoveEBooks.Name = "btnRemoveEBooks";
            this.btnRemoveEBooks.Size = new System.Drawing.Size(391, 126);
            this.btnRemoveEBooks.TabIndex = 11;
            this.btnRemoveEBooks.Text = "Remove E-Books";
            this.btnRemoveEBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveEBooks.UseCustomBackColor = true;
            this.btnRemoveEBooks.UseSelectable = true;
            this.btnRemoveEBooks.Click += new System.EventHandler(this.btnRemoveEBooks_Click);
            // 
            // btnAvailableEBooks
            // 
            this.btnAvailableEBooks.ActiveControl = null;
            this.btnAvailableEBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvailableEBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnAvailableEBooks.Location = new System.Drawing.Point(100, 291);
            this.btnAvailableEBooks.Name = "btnAvailableEBooks";
            this.btnAvailableEBooks.Size = new System.Drawing.Size(391, 148);
            this.btnAvailableEBooks.TabIndex = 12;
            this.btnAvailableEBooks.Text = "View Available E-Books";
            this.btnAvailableEBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAvailableEBooks.UseCustomBackColor = true;
            this.btnAvailableEBooks.UseSelectable = true;
            this.btnAvailableEBooks.Click += new System.EventHandler(this.btnAvailableEBooks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 749);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ucbr_ebooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnRemoveEBooks);
            this.Controls.Add(this.btnAvailableEBooks);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucbr_ebooks";
            this.Size = new System.Drawing.Size(1000, 650);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile btnRemoveEBooks;
        private MetroFramework.Controls.MetroTile btnAvailableEBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
