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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        MySqlCommand cmd;

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            MySqlDataAdapter sda = new MySqlDataAdapter("Select max(BookId) AS MaximumId from Book", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int num = Convert.ToInt32(dt.Rows[0][0]);
            int newId = num + 1;
            tb_bookId.Text = Convert.ToString(newId);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");

            con.Open();
            int bookId, brid, pges;
            string bookName, author, catg;
            bookId = Convert.ToInt32(tb_bookId.Text);
            brid = Convert.ToInt32(tbBrid.Text);
            pges = Convert.ToInt32(tb_pages.Text);
            bookName = tb_bookName.Text;
            author = tb_author.Text;
            catg = cmb_category.Text;

            try
            {
                cmd = new MySqlCommand("Insert into Book values(@a,@b,@c,@d,@e,@f)", con);
                cmd.Parameters.AddWithValue("a", bookId);
                cmd.Parameters.AddWithValue("b", bookName);
                cmd.Parameters.AddWithValue("c", author);
                cmd.Parameters.AddWithValue("d", pges);
                cmd.Parameters.AddWithValue("e", catg);
                cmd.Parameters.AddWithValue("f", brid);

                
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                con.Close();
                cmd.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
