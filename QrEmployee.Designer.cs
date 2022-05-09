namespace library_zone
{
    partial class QrEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QrEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintQr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.memberDataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnGrenerateQr = new Bunifu.Framework.UI.BunifuFlatButton();
            this.qrBox = new System.Windows.Forms.PictureBox();
            this.tb_qrName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_EmpUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(-3, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1009, 11);
            this.label1.TabIndex = 143;
            // 
            // btnPrintQr
            // 
            this.btnPrintQr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnPrintQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintQr.BorderRadius = -35;
            this.btnPrintQr.ButtonText = "PRINT  QR";
            this.btnPrintQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintQr.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintQr.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintQr.Iconimage = null;
            this.btnPrintQr.Iconimage_right = null;
            this.btnPrintQr.Iconimage_right_Selected = null;
            this.btnPrintQr.Iconimage_Selected = null;
            this.btnPrintQr.IconMarginLeft = 0;
            this.btnPrintQr.IconMarginRight = 0;
            this.btnPrintQr.IconRightVisible = true;
            this.btnPrintQr.IconRightZoom = 0D;
            this.btnPrintQr.IconVisible = true;
            this.btnPrintQr.IconZoom = 90D;
            this.btnPrintQr.IsTab = false;
            this.btnPrintQr.Location = new System.Drawing.Point(144, 587);
            this.btnPrintQr.Name = "btnPrintQr";
            this.btnPrintQr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnPrintQr.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPrintQr.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnPrintQr.selected = false;
            this.btnPrintQr.Size = new System.Drawing.Size(199, 31);
            this.btnPrintQr.TabIndex = 142;
            this.btnPrintQr.Text = "PRINT  QR";
            this.btnPrintQr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintQr.Textcolor = System.Drawing.Color.White;
            this.btnPrintQr.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintQr.Click += new System.EventHandler(this.btnPrintQr_Click);
            // 
            // memberDataTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.memberDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.memberDataTable.BackgroundColor = System.Drawing.Color.White;
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
            this.memberDataTable.Location = new System.Drawing.Point(429, 209);
            this.memberDataTable.Name = "memberDataTable";
            this.memberDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.memberDataTable.Size = new System.Drawing.Size(559, 372);
            this.memberDataTable.TabIndex = 141;
            this.memberDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberDataTable_CellContentClick);
            // 
            // btnGrenerateQr
            // 
            this.btnGrenerateQr.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGrenerateQr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnGrenerateQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrenerateQr.BorderRadius = -35;
            this.btnGrenerateQr.ButtonText = "GENERATE  QR";
            this.btnGrenerateQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrenerateQr.DisabledColor = System.Drawing.Color.Gray;
            this.btnGrenerateQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrenerateQr.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGrenerateQr.Iconimage = null;
            this.btnGrenerateQr.Iconimage_right = null;
            this.btnGrenerateQr.Iconimage_right_Selected = null;
            this.btnGrenerateQr.Iconimage_Selected = null;
            this.btnGrenerateQr.IconMarginLeft = 0;
            this.btnGrenerateQr.IconMarginRight = 0;
            this.btnGrenerateQr.IconRightVisible = true;
            this.btnGrenerateQr.IconRightZoom = 0D;
            this.btnGrenerateQr.IconVisible = true;
            this.btnGrenerateQr.IconZoom = 90D;
            this.btnGrenerateQr.IsTab = false;
            this.btnGrenerateQr.Location = new System.Drawing.Point(144, 329);
            this.btnGrenerateQr.Name = "btnGrenerateQr";
            this.btnGrenerateQr.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnGrenerateQr.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGrenerateQr.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnGrenerateQr.selected = false;
            this.btnGrenerateQr.Size = new System.Drawing.Size(199, 31);
            this.btnGrenerateQr.TabIndex = 140;
            this.btnGrenerateQr.Text = "GENERATE  QR";
            this.btnGrenerateQr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGrenerateQr.Textcolor = System.Drawing.Color.White;
            this.btnGrenerateQr.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrenerateQr.Click += new System.EventHandler(this.btnGrenerateQr_Click);
            // 
            // qrBox
            // 
            this.qrBox.Location = new System.Drawing.Point(130, 430);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(237, 151);
            this.qrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrBox.TabIndex = 139;
            this.qrBox.TabStop = false;
            // 
            // tb_qrName
            // 
            this.tb_qrName.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_qrName.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_qrName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_qrName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_qrName.BorderThickness = 2;
            this.tb_qrName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_qrName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_qrName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_qrName.isPassword = false;
            this.tb_qrName.Location = new System.Drawing.Point(228, 264);
            this.tb_qrName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_qrName.Name = "tb_qrName";
            this.tb_qrName.Size = new System.Drawing.Size(174, 28);
            this.tb_qrName.TabIndex = 138;
            this.tb_qrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(68, 269);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(158, 23);
            this.bunifuCustomLabel3.TabIndex = 137;
            this.bunifuCustomLabel3.Text = "QR image file name";
            // 
            // tb_EmpUserName
            // 
            this.tb_EmpUserName.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_EmpUserName.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_EmpUserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_EmpUserName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_EmpUserName.BorderThickness = 2;
            this.tb_EmpUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_EmpUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_EmpUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_EmpUserName.isPassword = false;
            this.tb_EmpUserName.Location = new System.Drawing.Point(228, 209);
            this.tb_EmpUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_EmpUserName.Name = "tb_EmpUserName";
            this.tb_EmpUserName.Size = new System.Drawing.Size(174, 28);
            this.tb_EmpUserName.TabIndex = 136;
            this.tb_EmpUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(68, 214);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel2.TabIndex = 135;
            this.bunifuCustomLabel2.Text = "User Name";
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
            this.btn_back.Location = new System.Drawing.Point(878, 587);
            this.btn_back.Name = "btn_back";
            this.btn_back.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_back.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_back.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_back.selected = false;
            this.btn_back.Size = new System.Drawing.Size(99, 31);
            this.btn_back.TabIndex = 132;
            this.btn_back.Text = "BACK";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Textcolor = System.Drawing.Color.White;
            this.btn_back.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.metroTile2.Location = new System.Drawing.Point(1, 170);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(200, 2);
            this.metroTile2.TabIndex = 130;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(191, 151);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(366, 38);
            this.bunifuCustomLabel1.TabIndex = 131;
            this.bunifuCustomLabel1.Text = "Create QR For Employers";
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
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // QrEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintQr);
            this.Controls.Add(this.memberDataTable);
            this.Controls.Add(this.btnGrenerateQr);
            this.Controls.Add(this.qrBox);
            this.Controls.Add(this.tb_qrName);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.tb_EmpUserName);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QrEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QrEmployee";
            this.Load += new System.EventHandler(this.QrEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintQr;
        private Bunifu.Framework.UI.BunifuCustomDataGrid memberDataTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnGrenerateQr;
        private System.Windows.Forms.PictureBox qrBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_qrName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_EmpUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_back;
        private MetroFramework.Controls.MetroTile metroTile2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}