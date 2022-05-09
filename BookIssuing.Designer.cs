namespace library_zone
{
    partial class BookIssuing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookIssuing));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_QRcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.btnStart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCheck = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bookDataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tb_bookName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_bookId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tb_member = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtp_issuedate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bookIssueDataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnIssue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDone = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblback = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssueDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.metroTile2.Location = new System.Drawing.Point(0, 151);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(200, 2);
            this.metroTile2.TabIndex = 98;
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(190, 132);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(366, 38);
            this.bunifuCustomLabel1.TabIndex = 99;
            this.bunifuCustomLabel1.Text = "Book Issuing";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // tb_QRcode
            // 
            this.tb_QRcode.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_QRcode.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_QRcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_QRcode.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_QRcode.BorderThickness = 2;
            this.tb_QRcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_QRcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_QRcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_QRcode.isPassword = false;
            this.tb_QRcode.Location = new System.Drawing.Point(145, 489);
            this.tb_QRcode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_QRcode.Name = "tb_QRcode";
            this.tb_QRcode.Size = new System.Drawing.Size(278, 71);
            this.tb_QRcode.TabIndex = 106;
            this.tb_QRcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(142, 204);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel4.TabIndex = 105;
            this.bunifuCustomLabel4.Text = "Camera";
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(145, 245);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(271, 169);
            this.pbCamera.TabIndex = 107;
            this.pbCamera.TabStop = false;
            // 
            // cmbDevice
            // 
            this.cmbDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevice.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(224, 201);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(192, 24);
            this.cmbDevice.TabIndex = 108;
            // 
            // btnStart
            // 
            this.btnStart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.BorderRadius = -35;
            this.btnStart.ButtonText = "SCAN";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DisabledColor = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStart.Iconimage = null;
            this.btnStart.Iconimage_right = null;
            this.btnStart.Iconimage_right_Selected = null;
            this.btnStart.Iconimage_Selected = null;
            this.btnStart.IconMarginLeft = 0;
            this.btnStart.IconMarginRight = 0;
            this.btnStart.IconRightVisible = true;
            this.btnStart.IconRightZoom = 0D;
            this.btnStart.IconVisible = true;
            this.btnStart.IconZoom = 90D;
            this.btnStart.IsTab = false;
            this.btnStart.Location = new System.Drawing.Point(208, 420);
            this.btnStart.Name = "btnStart";
            this.btnStart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnStart.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnStart.selected = false;
            this.btnStart.Size = new System.Drawing.Size(131, 31);
            this.btnStart.TabIndex = 111;
            this.btnStart.Text = "SCAN";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Textcolor = System.Drawing.Color.White;
            this.btnStart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.BorderRadius = -35;
            this.btnCheck.ButtonText = "CHECK";
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheck.Iconimage = null;
            this.btnCheck.Iconimage_right = null;
            this.btnCheck.Iconimage_right_Selected = null;
            this.btnCheck.Iconimage_Selected = null;
            this.btnCheck.IconMarginLeft = 0;
            this.btnCheck.IconMarginRight = 0;
            this.btnCheck.IconRightVisible = true;
            this.btnCheck.IconRightZoom = 0D;
            this.btnCheck.IconVisible = true;
            this.btnCheck.IconZoom = 90D;
            this.btnCheck.IsTab = false;
            this.btnCheck.Location = new System.Drawing.Point(208, 567);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnCheck.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCheck.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnCheck.selected = false;
            this.btnCheck.Size = new System.Drawing.Size(131, 31);
            this.btnCheck.TabIndex = 112;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheck.Textcolor = System.Drawing.Color.White;
            this.btnCheck.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bookDataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bookDataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bookDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataTable.DoubleBuffered = true;
            this.bookDataTable.EnableHeadersVisualStyles = false;
            this.bookDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bookDataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bookDataTable.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.bookDataTable.Location = new System.Drawing.Point(471, 201);
            this.bookDataTable.Name = "bookDataTable";
            this.bookDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookDataTable.Size = new System.Drawing.Size(498, 69);
            this.bookDataTable.TabIndex = 113;
            this.bookDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataTable_CellContentClick);
            // 
            // tb_bookName
            // 
            this.tb_bookName.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_bookName.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_bookName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_bookName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_bookName.BorderThickness = 2;
            this.tb_bookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_bookName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_bookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_bookName.isPassword = false;
            this.tb_bookName.Location = new System.Drawing.Point(680, 335);
            this.tb_bookName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bookName.Name = "tb_bookName";
            this.tb_bookName.Size = new System.Drawing.Size(202, 28);
            this.tb_bookName.TabIndex = 117;
            this.tb_bookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(520, 340);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel2.TabIndex = 116;
            this.bunifuCustomLabel2.Text = "Book Name";
            // 
            // tb_bookId
            // 
            this.tb_bookId.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_bookId.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_bookId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_bookId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_bookId.BorderThickness = 2;
            this.tb_bookId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_bookId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_bookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_bookId.isPassword = false;
            this.tb_bookId.Location = new System.Drawing.Point(680, 299);
            this.tb_bookId.Margin = new System.Windows.Forms.Padding(4);
            this.tb_bookId.Name = "tb_bookId";
            this.tb_bookId.Size = new System.Drawing.Size(202, 28);
            this.tb_bookId.TabIndex = 115;
            this.tb_bookId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(520, 304);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel3.TabIndex = 114;
            this.bunifuCustomLabel3.Text = "Book Id";
            // 
            // tb_member
            // 
            this.tb_member.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_member.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_member.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_member.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_member.BorderThickness = 2;
            this.tb_member.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_member.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_member.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_member.isPassword = false;
            this.tb_member.Location = new System.Drawing.Point(680, 407);
            this.tb_member.Margin = new System.Windows.Forms.Padding(4);
            this.tb_member.Name = "tb_member";
            this.tb_member.Size = new System.Drawing.Size(202, 28);
            this.tb_member.TabIndex = 121;
            this.tb_member.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(520, 412);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(153, 23);
            this.bunifuCustomLabel5.TabIndex = 120;
            this.bunifuCustomLabel5.Text = "Member User Name";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(520, 376);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel6.TabIndex = 118;
            this.bunifuCustomLabel6.Text = "Date";
            // 
            // dtp_issuedate
            // 
            this.dtp_issuedate.BackColor = System.Drawing.SystemColors.Control;
            this.dtp_issuedate.BorderRadius = 0;
            this.dtp_issuedate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.dtp_issuedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_issuedate.FormatCustom = null;
            this.dtp_issuedate.Location = new System.Drawing.Point(680, 372);
            this.dtp_issuedate.Name = "dtp_issuedate";
            this.dtp_issuedate.Size = new System.Drawing.Size(202, 28);
            this.dtp_issuedate.TabIndex = 122;
            this.dtp_issuedate.Value = new System.DateTime(2021, 8, 2, 0, 0, 0, 0);
            // 
            // bookIssueDataTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bookIssueDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bookIssueDataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bookIssueDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookIssueDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookIssueDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bookIssueDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookIssueDataTable.DoubleBuffered = true;
            this.bookIssueDataTable.EnableHeadersVisualStyles = false;
            this.bookIssueDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bookIssueDataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bookIssueDataTable.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.bookIssueDataTable.Location = new System.Drawing.Point(430, 491);
            this.bookIssueDataTable.Name = "bookIssueDataTable";
            this.bookIssueDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bookIssueDataTable.Size = new System.Drawing.Size(558, 69);
            this.bookIssueDataTable.TabIndex = 123;
            // 
            // btnIssue
            // 
            this.btnIssue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIssue.BorderRadius = -35;
            this.btnIssue.ButtonText = "ISSUE";
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.DisabledColor = System.Drawing.Color.Gray;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIssue.Iconimage = null;
            this.btnIssue.Iconimage_right = null;
            this.btnIssue.Iconimage_right_Selected = null;
            this.btnIssue.Iconimage_Selected = null;
            this.btnIssue.IconMarginLeft = 0;
            this.btnIssue.IconMarginRight = 0;
            this.btnIssue.IconRightVisible = true;
            this.btnIssue.IconRightZoom = 0D;
            this.btnIssue.IconVisible = true;
            this.btnIssue.IconZoom = 90D;
            this.btnIssue.IsTab = false;
            this.btnIssue.Location = new System.Drawing.Point(607, 442);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnIssue.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnIssue.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnIssue.selected = false;
            this.btnIssue.Size = new System.Drawing.Size(131, 31);
            this.btnIssue.TabIndex = 124;
            this.btnIssue.Text = "ISSUE";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIssue.Textcolor = System.Drawing.Color.White;
            this.btnIssue.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnDone
            // 
            this.btnDone.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDone.BorderRadius = -35;
            this.btnDone.ButtonText = "DONE";
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.DisabledColor = System.Drawing.Color.Gray;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDone.Iconimage = null;
            this.btnDone.Iconimage_right = null;
            this.btnDone.Iconimage_right_Selected = null;
            this.btnDone.Iconimage_Selected = null;
            this.btnDone.IconMarginLeft = 0;
            this.btnDone.IconMarginRight = 0;
            this.btnDone.IconRightVisible = true;
            this.btnDone.IconRightZoom = 0D;
            this.btnDone.IconVisible = true;
            this.btnDone.IconZoom = 90D;
            this.btnDone.IsTab = false;
            this.btnDone.Location = new System.Drawing.Point(607, 566);
            this.btnDone.Name = "btnDone";
            this.btnDone.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnDone.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDone.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnDone.selected = false;
            this.btnDone.Size = new System.Drawing.Size(131, 31);
            this.btnDone.TabIndex = 125;
            this.btnDone.Text = "DONE";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDone.Textcolor = System.Drawing.Color.White;
            this.btnDone.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(-3, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1009, 11);
            this.label1.TabIndex = 126;
            // 
            // lblback
            // 
            this.lblback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblback.Location = new System.Drawing.Point(888, 147);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(100, 23);
            this.lblback.TabIndex = 139;
            this.lblback.Text = "<< Back";
            this.lblback.Click += new System.EventHandler(this.lblback_Click);
            // 
            // BookIssuing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.bookIssueDataTable);
            this.Controls.Add(this.dtp_issuedate);
            this.Controls.Add(this.tb_member);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.tb_bookName);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.tb_bookId);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bookDataTable);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.tb_QRcode);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookIssuing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookIssuing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookIssuing_FormClosing);
            this.Load += new System.EventHandler(this.BookIssuing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookIssueDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_QRcode;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.ComboBox cmbDevice;
        private Bunifu.Framework.UI.BunifuFlatButton btnStart;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheck;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bookDataTable;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_bookName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_bookId;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_member;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker dtp_issuedate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bookIssueDataTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnIssue;
        private Bunifu.Framework.UI.BunifuFlatButton btnDone;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblback;
    }
}