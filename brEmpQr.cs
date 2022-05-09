using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using MySql.Data.MySqlClient;

namespace library_zone
{
    public partial class brEmpQr : Form
    {
        public brEmpQr()
        {
            InitializeComponent();
        }
        MySqlDataAdapter sda;
        private void tb_BrId_OnValueChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            sda = new MySqlDataAdapter("Select UserName,FirstName,LastName,Address,BranchId from Employee where BranchId = '"+tb_BrId.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            memberDataTable.DataSource = dt;
        }

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memberDataTable.Rows[e.RowIndex];
                tb_EmpUserName.Text = row.Cells["UserName"].Value.ToString();
                tb_qrName.Text = row.Cells["FirstName"].Value.ToString();
            }
        }

        private void btnGrenerateQr_Click(object sender, EventArgs e)
        {
            string qrData = tb_EmpUserName.Text;
            string qrFile = tb_qrName.Text;

            BarcodeWriter qrWriter = new BarcodeWriter();
            qrWriter.Format = BarcodeFormat.QR_CODE;
            qrWriter.Write(qrData).Save(@"D:\Smart Library Zone\qrImages\Employers\" + qrFile + ".png");
            qrBox.Image = Image.FromFile(@"D:\Smart Library Zone\qrImages\Employers\" + qrFile + ".png");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void brEmpQr_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            sda = new MySqlDataAdapter("Select UserName,FirstName,LastName,Address from Employee", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            memberDataTable.DataSource = dt;
        }
    }
}
