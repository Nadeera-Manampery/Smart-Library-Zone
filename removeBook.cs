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
    public partial class removeBook : Form
    {
        public removeBook()
        {
            InitializeComponent();
        }
        MySqlDataAdapter sda;
        MySqlCommand cmd;

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeBook_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            sda = new MySqlDataAdapter("Select * from Book", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            memberDataTable.DataSource = dt;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_bookId.Text);
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            try
            {
                cmd = new MySqlCommand("Delete From Book WHERE BookId= @a ",con);
                cmd.Parameters.AddWithValue("a", id);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data delete successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Data cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Refresh();
            sda = new MySqlDataAdapter("Select * from Book", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            memberDataTable.DataSource = dt;
            con.Close();
            cmd.Dispose();
        }
    }
}
