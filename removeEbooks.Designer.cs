namespace library_zone
{
    partial class removeEbooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(removeEbooks));
            this.memberDataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_ebookId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // memberDataTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.memberDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.memberDataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.memberDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.memberDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.memberDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataTable.DoubleBuffered = true;
            this.memberDataTable.EnableHeadersVisualStyles = false;
            this.memberDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.memberDataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.memberDataTable.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.memberDataTable.Location = new System.Drawing.Point(101, 293);
            this.memberDataTable.Name = "memberDataTable";
            this.memberDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.memberDataTable.Size = new System.Drawing.Size(806, 236);
            this.memberDataTable.TabIndex = 111;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(633, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 28);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 110;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.metroTile1.Location = new System.Drawing.Point(1, 639);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(1000, 11);
            this.metroTile1.TabIndex = 109;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // btn_back
            // 
            this.btn_back.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.BorderRadius = -35;
            this.btn_back.ButtonText = "BACK";
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.DisabledColor = System.Drawing.Color.Gray;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_back.Iconimage = null;
            this.btn_back.Iconimage_right = null;
            this.btn_back.Iconimage_right_Selected = null;
            this.btn_back.Iconimage_Selected = null;
            this.btn_back.IconMarginLeft = 0;
            this.btn_back.IconMarginRight = 0;
            this.btn_back.IconRightVisible = true;
            this.btn_back.IconRightZoom = 0D;
            this.btn_back.IconVisible = true;
            this.btn_back.IconZoom = 90D;
            this.btn_back.IsTab = false;
            this.btn_back.Location = new System.Drawing.Point(80, 583);
            this.btn_back.Name = "btn_back";
            this.btn_back.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_back.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_back.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_back.selected = false;
            this.btn_back.Size = new System.Drawing.Size(99, 31);
            this.btn_back.TabIndex = 108;
            this.btn_back.Text = "BACK";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Textcolor = System.Drawing.Color.White;
            this.btn_back.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_ebookId
            // 
            this.tb_ebookId.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_ebookId.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_ebookId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_ebookId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_ebookId.BorderThickness = 2;
            this.tb_ebookId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ebookId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_ebookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_ebookId.isPassword = false;
            this.tb_ebookId.Location = new System.Drawing.Point(463, 233);
            this.tb_ebookId.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ebookId.Name = "tb_ebookId";
            this.tb_ebookId.Size = new System.Drawing.Size(135, 28);
            this.tb_ebookId.TabIndex = 107;
            this.tb_ebookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(351, 234);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(105, 18);
            this.bunifuCustomLabel2.TabIndex = 106;
            this.bunifuCustomLabel2.Text = "Book ID";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.metroTile2.Location = new System.Drawing.Point(1, 170);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(200, 2);
            this.metroTile2.TabIndex = 104;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(198, 151);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(366, 38);
            this.bunifuCustomLabel1.TabIndex = 105;
            this.bunifuCustomLabel1.Text = "Remove E-Books";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // removeEbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.memberDataTable);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tb_ebookId);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "removeEbooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "removeEbooks";
            this.Load += new System.EventHandler(this.removeEbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid memberDataTable;
        private System.Windows.Forms.PictureBox btnDelete;
        private MetroFramework.Controls.MetroTile metroTile1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_back;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_ebookId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MetroFramework.Controls.MetroTile metroTile2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}