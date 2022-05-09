using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace library_zone
{
    public partial class resetMemberPassword : Form
    {
        string randomCode;
        public resetMemberPassword()
        {
            InitializeComponent();
        }

        private void resetMemberPassword_Load(object sender, EventArgs e)
        {
            lblnewpw.Visible = false;
            lblconfirm.Visible = false;
            tbnewpw.Visible = false;
            tbConfirmPw.Visible = false;
            btnReset.Visible = false;
            lblUserName.Visible = false;
            lblvalidation.Visible = false;
            tbUserName.Visible = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            MySqlDataAdapter sda = new MySqlDataAdapter("select email from member where email = '" + tb_email.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                string to, from, pw, messagebody;
                Random random = new Random();
                randomCode = (random.Next(999999)).ToString();
                MailMessage mailMessage = new MailMessage();
                to = (tb_email.Text).ToString();
                from = "lzoneonline192@gmail.com";
                pw = "TpNibm192#";
                messagebody = "Your password reset verify code is " + randomCode;
                MailMessage message = new MailMessage();
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Reset password - LZone";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pw);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("verification code has been sent! \n please check your gmail.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Cant send your code at the moment. please chack again shortly.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Email does not exits", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (randomCode == (tb_code.Text).ToString())
            {
                lblnewpw.Visible = true;
                lblconfirm.Visible = true;
                tbnewpw.Visible = true;
                tbConfirmPw.Visible = true;
                btnReset.Visible = true;
                lblUserName.Visible = true;
                lblvalidation.Visible = true;
                tbUserName.Visible = true;
            }
            else
            {
                MessageBox.Show("Incorrect verify code. Please check again!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            if ((tbnewpw.Text).ToString() == (tbConfirmPw.Text).ToString())
            {
                try
                {
                    MySqlCommand cmd1 = new MySqlCommand("Update memberlogin SET Password='" + (tbnewpw.Text).ToString() + "' where UserName = '"+tbUserName.Text+"'", con);
                    int i = cmd1.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Password reset successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("cant reset your password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cmd1.Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("System error", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lblvalidation.Text = "*must be same";
            }
        }

        private void lblnewpw_Click(object sender, EventArgs e)
        {

        }

        private void tbnewpw_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
