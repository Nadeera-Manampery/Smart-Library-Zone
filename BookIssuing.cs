using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MySql.Data.MySqlClient;

namespace library_zone
{
    public partial class BookIssuing : Form
    {
        public BookIssuing()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        MySqlDataAdapter sda1;
        MySqlDataAdapter sda2;
        MySqlCommand cmd;
        private void BookIssuing_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cmbDevice.Items.Add(filterInfo.Name);
            cmbDevice.SelectedIndex = 0;

            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cmbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BookIssuing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbCamera.Image);
                if (result != null)
                {
                    tb_QRcode.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            string bookName = tb_QRcode.Text;
            sda1 = new MySqlDataAdapter("Select BookId,BookName,AuthorName,Pages from Book where BookName = '"+bookName+"' ", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            con.Close();
            bookDataTable.DataSource = dt1;
        }

        private void bookDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bookDataTable.Rows[e.RowIndex];
                tb_bookId.Text = row.Cells["BookId"].Value.ToString();
                tb_bookName.Text = row.Cells["BookName"].Value.ToString();
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=Lzone");
            con.Open();
            int bookId;
            string bookName, Member;
            DateTime issuedate,fdate;
            bookId = Convert.ToInt32(tb_bookId.Text);
            issuedate = dtp_issuedate.Value;
            Member = tb_member.Text;
            bookName = tb_bookName.Text;
            fdate = DateTime.Today.AddDays(+30);
            cmd = new MySqlCommand("Insert into bookissue values (@a,@b,@c,@d,@e)", con);
            cmd.Parameters.AddWithValue("a",issuedate);
            cmd.Parameters.AddWithValue("b",bookId);
            cmd.Parameters.AddWithValue("c",bookName);
            cmd.Parameters.AddWithValue("d",Member);
            cmd.Parameters.AddWithValue("e",fdate);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sda2 = new MySqlDataAdapter("Select * from bookissue where BookName = '" + bookName + "' ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            con.Close();
            bookIssueDataTable.DataSource = dt2;
            cmd.Dispose();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
