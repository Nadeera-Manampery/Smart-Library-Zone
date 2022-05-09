namespace library_zone
{
    partial class updateMember
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
            this.btnBack = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblemail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbContact = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblcontact = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbladdrs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbLn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblln = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbFn = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblfn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.memberDataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_check = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnBack.Location = new System.Drawing.Point(828, 588);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 23);
            this.btnBack.TabIndex = 143;
            this.btnBack.Text = "<< Back to dashboad";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(-8, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 10);
            this.label1.TabIndex = 142;
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleName = "btnUpdate";
            this.btnupdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.BorderRadius = -30;
            this.btnupdate.ButtonText = "UPDATE";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnupdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnupdate.Iconimage = null;
            this.btnupdate.Iconimage_right = null;
            this.btnupdate.Iconimage_right_Selected = null;
            this.btnupdate.Iconimage_Selected = null;
            this.btnupdate.IconMarginLeft = 0;
            this.btnupdate.IconMarginRight = 0;
            this.btnupdate.IconRightVisible = true;
            this.btnupdate.IconRightZoom = 0D;
            this.btnupdate.IconVisible = false;
            this.btnupdate.IconZoom = 90D;
            this.btnupdate.IsTab = false;
            this.btnupdate.Location = new System.Drawing.Point(679, 467);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnupdate.OnHovercolor = System.Drawing.Color.White;
            this.btnupdate.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnupdate.selected = false;
            this.btnupdate.Size = new System.Drawing.Size(155, 28);
            this.btnupdate.TabIndex = 141;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Textcolor = System.Drawing.Color.White;
            this.btnupdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tbEmail.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbEmail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbEmail.BorderThickness = 2;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbEmail.isPassword = false;
            this.tbEmail.Location = new System.Drawing.Point(679, 339);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 28);
            this.tbEmail.TabIndex = 140;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblemail
            // 
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblemail.Location = new System.Drawing.Point(572, 344);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(100, 23);
            this.lblemail.TabIndex = 139;
            this.lblemail.Text = "Email";
            // 
            // tbContact
            // 
            this.tbContact.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tbContact.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbContact.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbContact.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbContact.BorderThickness = 2;
            this.tbContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContact.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbContact.isPassword = false;
            this.tbContact.Location = new System.Drawing.Point(267, 388);
            this.tbContact.Margin = new System.Windows.Forms.Padding(4);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(152, 28);
            this.tbContact.TabIndex = 138;
            this.tbContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblcontact
            // 
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblcontact.Location = new System.Drawing.Point(166, 393);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(100, 23);
            this.lblcontact.TabIndex = 137;
            this.lblcontact.Text = "Contact";
            // 
            // tbAddress
            // 
            this.tbAddress.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tbAddress.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbAddress.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbAddress.BorderThickness = 2;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbAddress.isPassword = false;
            this.tbAddress.Location = new System.Drawing.Point(679, 292);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(152, 28);
            this.tbAddress.TabIndex = 136;
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbladdrs
            // 
            this.lbladdrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lbladdrs.Location = new System.Drawing.Point(572, 297);
            this.lbladdrs.Name = "lbladdrs";
            this.lbladdrs.Size = new System.Drawing.Size(100, 23);
            this.lbladdrs.TabIndex = 135;
            this.lbladdrs.Text = "Address";
            // 
            // tbLn
            // 
            this.tbLn.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tbLn.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbLn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbLn.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbLn.BorderThickness = 2;
            this.tbLn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbLn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbLn.isPassword = false;
            this.tbLn.Location = new System.Drawing.Point(267, 339);
            this.tbLn.Margin = new System.Windows.Forms.Padding(4);
            this.tbLn.Name = "tbLn";
            this.tbLn.Size = new System.Drawing.Size(152, 28);
            this.tbLn.TabIndex = 132;
            this.tbLn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblln
            // 
            this.lblln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblln.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblln.Location = new System.Drawing.Point(166, 344);
            this.lblln.Name = "lblln";
            this.lblln.Size = new System.Drawing.Size(100, 23);
            this.lblln.TabIndex = 131;
            this.lblln.Text = "Last Name    ";
            // 
            // tbFn
            // 
            this.tbFn.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tbFn.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbFn.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbFn.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbFn.BorderThickness = 2;
            this.tbFn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFn.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbFn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbFn.isPassword = false;
            this.tbFn.Location = new System.Drawing.Point(267, 292);
            this.tbFn.Margin = new System.Windows.Forms.Padding(4);
            this.tbFn.Name = "tbFn";
            this.tbFn.Size = new System.Drawing.Size(152, 28);
            this.tbFn.TabIndex = 130;
            this.tbFn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblfn
            // 
            this.lblfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblfn.Location = new System.Drawing.Point(166, 297);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(100, 23);
            this.lblfn.TabIndex = 129;
            this.lblfn.Text = "First Name    ";
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
            this.memberDataTable.Location = new System.Drawing.Point(210, 122);
            this.memberDataTable.Name = "memberDataTable";
            this.memberDataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.memberDataTable.Size = new System.Drawing.Size(688, 94);
            this.memberDataTable.TabIndex = 128;
            this.memberDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberDataTable_CellContentClick);
            // 
            // btn_check
            // 
            this.btn_check.AccessibleName = "btn_login";
            this.btn_check.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_check.BorderRadius = -30;
            this.btn_check.ButtonText = "Check";
            this.btn_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_check.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_check.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_check.Iconimage = null;
            this.btn_check.Iconimage_right = null;
            this.btn_check.Iconimage_right_Selected = null;
            this.btn_check.Iconimage_Selected = null;
            this.btn_check.IconMarginLeft = 0;
            this.btn_check.IconMarginRight = 0;
            this.btn_check.IconRightVisible = true;
            this.btn_check.IconRightZoom = 0D;
            this.btn_check.IconVisible = false;
            this.btn_check.IconZoom = 90D;
            this.btn_check.IsTab = false;
            this.btn_check.Location = new System.Drawing.Point(624, 34);
            this.btn_check.Name = "btn_check";
            this.btn_check.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_check.OnHovercolor = System.Drawing.Color.White;
            this.btn_check.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_check.selected = false;
            this.btn_check.Size = new System.Drawing.Size(147, 28);
            this.btn_check.TabIndex = 127;
            this.btn_check.Text = "Check";
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_check.Textcolor = System.Drawing.Color.White;
            this.btn_check.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tb_username
            // 
            this.tb_username.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_username.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_username.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_username.BorderThickness = 2;
            this.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_username.isPassword = false;
            this.tb_username.Location = new System.Drawing.Point(362, 34);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(152, 28);
            this.tb_username.TabIndex = 126;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(261, 39);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel4.TabIndex = 123;
            this.bunifuCustomLabel4.Text = "User Name    :";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleName = "btnUpdate";
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = -30;
            this.btnReset.ButtonText = "RESET";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = null;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = false;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(160, 467);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.White;
            this.btnReset.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(155, 28);
            this.btnReset.TabIndex = 144;
            this.btnReset.Text = "RESET";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // updateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 641);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lbladdrs);
            this.Controls.Add(this.tbLn);
            this.Controls.Add(this.lblln);
            this.Controls.Add(this.tbFn);
            this.Controls.Add(this.lblfn);
            this.Controls.Add(this.memberDataTable);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "updateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateMember";
            this.Load += new System.EventHandler(this.updateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel btnBack;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnupdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblemail;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbContact;
        private Bunifu.Framework.UI.BunifuCustomLabel lblcontact;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel lbladdrs;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbLn;
        private Bunifu.Framework.UI.BunifuCustomLabel lblln;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbFn;
        private Bunifu.Framework.UI.BunifuCustomLabel lblfn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid memberDataTable;
        private Bunifu.Framework.UI.BunifuFlatButton btn_check;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_username;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
    }
}