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
using System.Text.RegularExpressions;


namespace library_zone
{
    public partial class BAregistration : Form
    {
        public BAregistration()
        {
            InitializeComponent();
        }
        
        MySqlCommand cmd1;
        MySqlCommand cmd2;
        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void BAregistration_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");

        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            int brid;
            string fname, lname, nic, address, tel, email, un, pwd;
            DateTime dob, regdate;
            brid = Convert.ToInt32(tb_brId.Text);
            if (string.IsNullOrEmpty(tb_fname.Text))
            {
                lblError.Text= "*First Name cannot be blank";
                tb_fname.Focus();
            }
            if (string.IsNullOrEmpty(tb_lname.Text))
            {
                lblError.Text = "*Last Name cannot be blank";
                tb_lname.Focus();
            }
            if (string.IsNullOrEmpty(tb_brId.Text))
            {
                lblError.Text = "*Branch Id cannot be blank";
                tb_brId.Focus();
            }
            if (string.IsNullOrEmpty(tb_nic.Text))
            {
                lblError.Text = "*NIC cannot be blank";
                tb_nic.Focus();
            }
            if (string.IsNullOrEmpty(tb_address.Text))
            {
                lblError.Text = "*Address cannot be blank";
                tb_address.Focus();
            }
            if (string.IsNullOrEmpty(tb_contact.Text))
            {
                lblError.Text = "*Contact cannot be blank";
                tb_contact.Focus();
            }
            fname = tb_fname.Text;
            lname = tb_lname.Text;
            nic = tb_nic.Text;
            address = tb_address.Text;
            tel = tb_contact.Text;
            email = tb_email.Text;
            un = tb_uname.Text;
            pwd = tb_pwd.Text;
            dob = dtp_dob.Value;
            regdate = dtp_regdate.Value;

            try
            {
                cmd1 = new MySqlCommand("Insert into Employee values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)", con);
                cmd1.Parameters.AddWithValue("a", un);
                cmd1.Parameters.AddWithValue("b", fname);
                cmd1.Parameters.AddWithValue("c", lname);
                cmd1.Parameters.AddWithValue("d", nic);
                cmd1.Parameters.AddWithValue("e", address);
                cmd1.Parameters.AddWithValue("f", dob);
                cmd1.Parameters.AddWithValue("g", tel);
                cmd1.Parameters.AddWithValue("h", email);
                cmd1.Parameters.AddWithValue("i", regdate);
                cmd1.Parameters.AddWithValue("j", brid);

                cmd2 = new MySqlCommand("Insert into BranchAdminLogin values(@m,@n)", con);
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
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_address.ResetText();
            tb_brId.ResetText();
            tb_contact.ResetText();
            tb_email.ResetText();
            tb_fname.ResetText();
            tb_lname.ResetText();
            tb_nic.ResetText();
            tb_pwd.ResetText();
            tb_uname.ResetText();
        }
    }
}
