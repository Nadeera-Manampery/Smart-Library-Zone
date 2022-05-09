namespace library_zone
{
    partial class resetpwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetpwd));
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_send = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tb_email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tb_code = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbnewpw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblnewpw = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbConfirmPw = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblconfirm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnVerify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblvalidation = new System.Windows.Forms.Label();
            this.cmbTyp = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(28, 75);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel4.TabIndex = 14;
            this.bunifuCustomLabel4.Text = "Enter Email   :";
            // 
            // btn_send
            // 
            this.btn_send.AccessibleName = "btn_login";
            this.btn_send.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.BorderRadius = -30;
            this.btn_send.ButtonText = "Send Code";
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_send.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_send.Iconimage = null;
            this.btn_send.Iconimage_right = null;
            this.btn_send.Iconimage_right_Selected = null;
            this.btn_send.Iconimage_Selected = null;
            this.btn_send.IconMarginLeft = 0;
            this.btn_send.IconMarginRight = 0;
            this.btn_send.IconRightVisible = true;
            this.btn_send.IconRightZoom = 0D;
            this.btn_send.IconVisible = false;
            this.btn_send.IconZoom = 90D;
            this.btn_send.IsTab = false;
            this.btn_send.Location = new System.Drawing.Point(361, 70);
            this.btn_send.Name = "btn_send";
            this.btn_send.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_send.OnHovercolor = System.Drawing.Color.White;
            this.btn_send.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btn_send.selected = false;
            this.btn_send.Size = new System.Drawing.Size(121, 28);
            this.btn_send.TabIndex = 13;
            this.btn_send.Text = "Send Code";
            this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_send.Textcolor = System.Drawing.Color.White;
            this.btn_send.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tb_email
            // 
            this.tb_email.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_email.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_email.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_email.BorderThickness = 2;
            this.tb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_email.isPassword = false;
            this.tb_email.Location = new System.Drawing.Point(145, 70);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(197, 28);
            this.tb_email.TabIndex = 16;
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tb_code
            // 
            this.tb_code.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tb_code.BorderColorFocused = System.Drawing.Color.Blue;
            this.tb_code.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_code.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tb_code.BorderThickness = 2;
            this.tb_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_code.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tb_code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tb_code.isPassword = false;
            this.tb_code.Location = new System.Drawing.Point(145, 132);
            this.tb_code.Margin = new System.Windows.Forms.Padding(4);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(197, 26);
            this.tb_code.TabIndex = 18;
            this.tb_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(28, 137);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 21);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Enter Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // tbnewpw
            // 
            this.tbnewpw.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tbnewpw.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbnewpw.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbnewpw.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbnewpw.BorderThickness = 2;
            this.tbnewpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbnewpw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbnewpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbnewpw.isPassword = true;
            this.tbnewpw.Location = new System.Drawing.Point(145, 238);
            this.tbnewpw.Margin = new System.Windows.Forms.Padding(4);
            this.tbnewpw.Name = "tbnewpw";
            this.tbnewpw.Size = new System.Drawing.Size(197, 26);
            this.tbnewpw.TabIndex = 22;
            this.tbnewpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblnewpw
            // 
            this.lblnewpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblnewpw.Location = new System.Drawing.Point(28, 243);
            this.lblnewpw.Name = "lblnewpw";
            this.lblnewpw.Size = new System.Drawing.Size(122, 21);
            this.lblnewpw.TabIndex = 21;
            this.lblnewpw.Text = "New password";
            // 
            // tbConfirmPw
            // 
            this.tbConfirmPw.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.tbConfirmPw.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbConfirmPw.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbConfirmPw.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbConfirmPw.BorderThickness = 2;
            this.tbConfirmPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbConfirmPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.tbConfirmPw.isPassword = true;
            this.tbConfirmPw.Location = new System.Drawing.Point(145, 302);
            this.tbConfirmPw.Margin = new System.Windows.Forms.Padding(4);
            this.tbConfirmPw.Name = "tbConfirmPw";
            this.tbConfirmPw.Size = new System.Drawing.Size(197, 26);
            this.tbConfirmPw.TabIndex = 24;
            this.tbConfirmPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblconfirm
            // 
            this.lblconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.lblconfirm.Location = new System.Drawing.Point(28, 307);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(122, 21);
            this.lblconfirm.TabIndex = 23;
            this.lblconfirm.Text = "Confirm";
            // 
            // btnReset
            // 
            this.btnReset.AccessibleName = "btn_login";
            this.btnReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = -30;
            this.btnReset.ButtonText = "Reset";
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
            this.btnReset.Location = new System.Drawing.Point(145, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.OnHovercolor = System.Drawing.Color.White;
            this.btnReset.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(121, 26);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnBack.Location = new System.Drawing.Point(546, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "<< Back to login";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.AccessibleName = "btn_login";
            this.btnVerify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerify.BorderRadius = -30;
            this.btnVerify.ButtonText = "Verify";
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnVerify.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerify.Iconimage = null;
            this.btnVerify.Iconimage_right = null;
            this.btnVerify.Iconimage_right_Selected = null;
            this.btnVerify.Iconimage_Selected = null;
            this.btnVerify.IconMarginLeft = 0;
            this.btnVerify.IconMarginRight = 0;
            this.btnVerify.IconRightVisible = true;
            this.btnVerify.IconRightZoom = 0D;
            this.btnVerify.IconVisible = false;
            this.btnVerify.IconZoom = 90D;
            this.btnVerify.IsTab = false;
            this.btnVerify.Location = new System.Drawing.Point(361, 130);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnVerify.OnHovercolor = System.Drawing.Color.White;
            this.btnVerify.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.btnVerify.selected = false;
            this.btnVerify.Size = new System.Drawing.Size(121, 28);
            this.btnVerify.TabIndex = 27;
            this.btnVerify.Text = "Verify";
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerify.Textcolor = System.Drawing.Color.White;
            this.btnVerify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lblvalidation
            // 
            this.lblvalidation.ForeColor = System.Drawing.Color.Red;
            this.lblvalidation.Location = new System.Drawing.Point(145, 332);
            this.lblvalidation.Name = "lblvalidation";
            this.lblvalidation.Size = new System.Drawing.Size(197, 19);
            this.lblvalidation.TabIndex = 29;
            // 
            // cmbTyp
            // 
            this.cmbTyp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.cmbTyp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(158)))), ((int)(((byte)(82)))));
            this.cmbTyp.FormattingEnabled = true;
            this.cmbTyp.ItemHeight = 23;
            this.cmbTyp.Items.AddRange(new object[] {
            "Main Admin",
            "Branch Admin",
            "Officer"});
            this.cmbTyp.Location = new System.Drawing.Point(31, 185);
            this.cmbTyp.Name = "cmbTyp";
            this.cmbTyp.Size = new System.Drawing.Size(311, 29);
            this.cmbTyp.TabIndex = 30;
            this.cmbTyp.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbTyp.UseCustomBackColor = true;
            this.cmbTyp.UseCustomForeColor = true;
            this.cmbTyp.UseSelectable = true;
            this.cmbTyp.UseStyleColors = true;
            this.cmbTyp.UseWaitCursor = true;
            // 
            // resetpwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 412);
            this.Controls.Add(this.cmbTyp);
            this.Controls.Add(this.lblvalidation);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbConfirmPw);
            this.Controls.Add(this.lblconfirm);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tbnewpw);
            this.Controls.Add(this.lblnewpw);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetpwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "resetpwd";
            this.Load += new System.EventHandler(this.resetpwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_send;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_email;
        private Bunifu.Framework.UI.BunifuMetroTextbox tb_code;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbnewpw;
        private Bunifu.Framework.UI.BunifuCustomLabel lblnewpw;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbConfirmPw;
        private Bunifu.Framework.UI.BunifuCustomLabel lblconfirm;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuCustomLabel btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerify;
        private System.Windows.Forms.Label lblvalidation;
        private MetroFramework.Controls.MetroComboBox cmbTyp;
    }
}