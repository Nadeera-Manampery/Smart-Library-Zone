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

namespace library_zone
{
    public partial class updateMember : Form
    {
        public updateMember()
        {
            InitializeComponent();
        }
        
        private void btn_check_Click(object sender, EventArgs e)
        {
            
            memberDataTable.Visible = true;
            string userName = tb_username.Text;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            MySqlDataAdapter sda = new MySqlDataAdapter("select UserName from member where UserName = '" + userName + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MySqlDataAdapter sda1 = new MySqlDataAdapter("select FirstName,LastName,Address,Contact,email from member where UserName='" + userName + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                memberDataTable.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Incorrect User Name!\nCheck again.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void updateMember_Load(object sender, EventArgs e)
        {
            memberDataTable.Visible = false;
        }

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memberDataTable.Rows[e.RowIndex];
                tbFn.Text = row.Cells["FirstName"].Value.ToString();
                tbLn.Text = row.Cells["LastName"].Value.ToString();
                tbContact.Text = row.Cells["Contact"].Value.ToString();
                tbAddress.Text = row.Cells["Address"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("update member SET FirstName='" + tbFn.Text + "' , LastName='" + tbLn.Text + "'," +
                "Contact='" + tbContact.Text + "',Address='" + tbAddress.Text + "'," +
                "email='" + tbEmail.Text + "' where UserName='" + tb_username.Text + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Successfully updated your info!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can't update your info!\nCheck again.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cmd.Dispose();
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tb_username.ResetText();
            tbLn.ResetText();
            tbFn.ResetText();
            tbEmail.ResetText();
            tbContact.ResetText();
            tbAddress.ResetText();
        }
    }
}
