using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_zone
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            string pwd = tb_pwd.Text;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            
            if(cmbLoginTyp.SelectedIndex == 0)
            {
                MySqlDataAdapter sda1 = new MySqlDataAdapter("select count(*) from mainadminlogin where UserName='" + tb_username.Text + "' and 	Password='" + tb_pwd.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    using (MainAdministrator mAdmin = new MainAdministrator()) {
                        mAdmin.receiveUser = userName;
                        mAdmin.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if(cmbLoginTyp.SelectedIndex == 1)
            {
                MySqlDataAdapter sda2 = new MySqlDataAdapter("select count(*) from branchadminlogin where UserName='" + tb_username.Text + "' and 	Password='" + tb_pwd.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda2.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    using (BranchAdministrator bAdmin = new BranchAdministrator()) {
                        bAdmin.receiveUser = userName;
                        bAdmin.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if(cmbLoginTyp.SelectedIndex == 2)
            {
                MySqlDataAdapter sda3 = new MySqlDataAdapter("select count(*) from officerlogin where UserName='" + tb_username.Text + "' and 	Password='" + tb_pwd.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda3.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    using (Officer sendToOfficer = new Officer()) {
                        sendToOfficer.receiveUser = userName;
                        sendToOfficer.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Please select login type!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbl_forgotpw_Click(object sender, EventArgs e)
        {
            resetpwd pwdreset = new resetpwd();
            this.Hide();
            pwdreset.Show();
        }

        private void lbl_forgotpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
