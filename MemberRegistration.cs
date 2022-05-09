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
    public partial class MemberRegistration : Form
    {
        public MemberRegistration()
        {
            InitializeComponent();
        }
        MySqlCommand cmd1;
        MySqlCommand cmd2;
        private void MemberRegistration_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            MySqlDataAdapter sda = new MySqlDataAdapter("Select max(MemberID) AS MaximumId from Member", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int num = Convert.ToInt32(dt.Rows[0][0]);
            int newId = num + 1;
            tbMemberId.Text = Convert.ToString(newId);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            int memId,brid;
            string fname, lname, address, tel, email, un, pwd, from, body, pass;
            DateTime dob, regdate;
            memId = Convert.ToInt32(tbMemberId.Text);
            brid = Convert.ToInt32(tb_brid.Text);
            fname = tb_fname.Text;
            lname = tb_lname.Text;
            address = tb_address.Text;
            tel = tb_contact.Text;
            email = tb_email.Text;
            un = tb_uname.Text;
            pwd = tb_pwd.Text;
            dob = dtp_dob.Value;
            regdate = dtp_regdate.Value;
            from= "lzoneonline192@gmail.com";
            pass = "TpNibm192#";
            body = "Welcome! You have registerd at L-Zone library system.";
            try
            {
                cmd1 = new MySqlCommand("Insert into Member values(@a,@d,@b,@c,@e,@f,@g,@h,@i,@j)", con);
                cmd1.Parameters.AddWithValue("a", un);
                cmd1.Parameters.AddWithValue("d", memId);
                cmd1.Parameters.AddWithValue("b", fname);
                cmd1.Parameters.AddWithValue("c", lname);
                cmd1.Parameters.AddWithValue("e", address);
                cmd1.Parameters.AddWithValue("f", dob);
                cmd1.Parameters.AddWithValue("g", tel);
                cmd1.Parameters.AddWithValue("h", email);
                cmd1.Parameters.AddWithValue("i", regdate);
                cmd1.Parameters.AddWithValue("j", brid);

                cmd2 = new MySqlCommand("Insert into MemberLogin values(@m,@n)", con);
                cmd2.Parameters.AddWithValue("m", un);
                cmd2.Parameters.AddWithValue("n", pwd);
                int i = cmd1.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int x = cmd2.ExecuteNonQuery();
                if (x != 0)
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd1.Dispose();
                cmd2.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MailMessage message = new MailMessage();
            message.To.Add(email);
            message.From = new MailAddress(from);
            message.Body = body;
            message.Subject = "Comfirm registration";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Send email to member successfully!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("can't send email to member!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
