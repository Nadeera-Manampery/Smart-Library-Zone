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
    public partial class cancelMembership : Form
    {
        public cancelMembership()
        {
            InitializeComponent();
        }

        private void removeBooks_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from member", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            memberDataTable.DataSource = dt;
        }

        private void tb_data_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            if (tb_data.Text == "")
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from member", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                memberDataTable.DataSource = dt;
            }
            else
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from member where UserName='" + tb_data.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                memberDataTable.DataSource = dt;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("Delete From MemberLogin WHERE UserName='" + tb_data.Text + "' ", con);
                int x = cmd1.ExecuteNonQuery();
                if (x == 1)
                {
                    MySqlCommand cmd = new MySqlCommand("Delete From Member WHERE UserName='" + tb_data.Text + "' ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("User Suspended!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cant remove member login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Refresh();
            MySqlDataAdapter sda = new MySqlDataAdapter("Select * from Member", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            memberDataTable.DataSource = dt;
            con.Close();
        }
    }
}
