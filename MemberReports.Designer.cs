namespace library_zone
{
    partial class MemberReports
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
            this.btnMemberAll = new MetroFramework.Controls.MetroTile();
            this.btnMmberBranch = new MetroFramework.Controls.MetroTile();
            this.btnMemberDate = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnMemberAll
            // 
            this.btnMemberAll.ActiveControl = null;
            this.btnMemberAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMemberAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnMemberAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemberAll.Location = new System.Drawing.Point(168, 69);
            this.btnMemberAll.Name = "btnMemberAll";
            this.btnMemberAll.Size = new System.Drawing.Size(220, 117);
            this.btnMemberAll.TabIndex = 1;
            this.btnMemberAll.Text = "All Members";
            this.btnMemberAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberAll.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberAll.UseCustomBackColor = true;
            this.btnMemberAll.UseCustomForeColor = true;
            this.btnMemberAll.UseSelectable = true;
            this.btnMemberAll.UseStyleColors = true;
            this.btnMemberAll.UseTileImage = true;
            this.btnMemberAll.Click += new System.EventHandler(this.btnMemberAll_Click);
            // 
            // btnMmberBranch
            // 
            this.btnMmberBranch.ActiveControl = null;
            this.btnMmberBranch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMmberBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnMmberBranch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMmberBranch.Location = new System.Drawing.Point(394, 69);
            this.btnMmberBranch.Name = "btnMmberBranch";
            this.btnMmberBranch.Size = new System.Drawing.Size(220, 117);
            this.btnMmberBranch.TabIndex = 2;
            this.btnMmberBranch.Text = "Member Report By Branch";
            this.btnMmberBranch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMmberBranch.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMmberBranch.UseCustomBackColor = true;
            this.btnMmberBranch.UseCustomForeColor = true;
            this.btnMmberBranch.UseSelectable = true;
            this.btnMmberBranch.UseStyleColors = true;
            this.btnMmberBranch.UseTileImage = true;
            this.btnMmberBranch.Click += new System.EventHandler(this.btnMmberBranch_Click);
            // 
            // btnMemberDate
            // 
            this.btnMemberDate.ActiveControl = null;
            this.btnMemberDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMemberDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnMemberDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMemberDate.Location = new System.Drawing.Point(168, 192);
            this.btnMemberDate.Name = "btnMemberDate";
            this.btnMemberDate.Size = new System.Drawing.Size(446, 117);
            this.btnMemberDate.TabIndex = 3;
            this.btnMemberDate.Text = "Members By Registrations Date";
            this.btnMemberDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberDate.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberDate.UseCustomBackColor = true;
            this.btnMemberDate.UseCustomForeColor = true;
            this.btnMemberDate.UseSelectable = true;
            this.btnMemberDate.UseStyleColors = true;
            this.btnMemberDate.UseTileImage = true;
            this.btnMemberDate.Click += new System.EventHandler(this.btnMemberDate_Click);
            // 
            // MemberReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnMemberDate);
            this.Controls.Add(this.btnMmberBranch);
            this.Controls.Add(this.btnMemberAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberReports";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnMemberAll;
        private MetroFramework.Controls.MetroTile btnMmberBranch;
        private MetroFramework.Controls.MetroTile btnMemberDate;
    }
}