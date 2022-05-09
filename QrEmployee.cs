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
    public partial class QrEmployee : Form
    {
        public QrEmployee()
        {
            InitializeComponent();
        }
        MySqlDataAdapter sda;
        private void QrEmployee_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            sda = new MySqlDataAdapter("Select UserName,FirstName,LastName,Address,BranchId from Employee", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            memberDataTable.DataSource = dt;
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

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memberDataTable.Rows[e.RowIndex];
                tb_EmpUserName.Text = row.Cells["UserName"].Value.ToString();
                tb_qrName.Text = row.Cells["FirstName"].Value.ToString();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrintQr_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.memberDataTable.Width, this.memberDataTable.Height);
            memberDataTable.DrawToBitmap(bm, new Rectangle(0, 0, this.memberDataTable.Width, this.memberDataTable.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
