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
    public partial class check_eligibility : Form
    {
        public check_eligibility()
        {
            InitializeComponent();
        }
        MySqlDataAdapter sda;
        MySqlDataAdapter sda2;
        private void check_eligibility_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            sda = new MySqlDataAdapter("Select * from bookissue", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            bookIssueDataTable.DataSource = dt;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            string UserName = tb_userName.Text;
            sda2 = new MySqlDataAdapter("Select * from bookissue where UserName = '" + UserName + "' ", con);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            con.Close();
            bookIssueDataTable.DataSource = dt;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            BookIssuing bookIssuing = new BookIssuing();
            bookIssuing.Show();
            this.Hide();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
