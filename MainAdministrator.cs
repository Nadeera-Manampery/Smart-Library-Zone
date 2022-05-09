using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;

namespace library_zone
{
    public partial class MainAdministrator : Form
    {
        public string receiveUser;
        public MainAdministrator()
        {
            InitializeComponent();
        }

        private void MainAdministrator_Load(object sender, EventArgs e)
        {
            lblUser.Text = receiveUser;
            //ucDashboard1.Visible = true;
            ucRegistration1.Visible = false;
            ucBooks1.Visible = false;
            ebooks1.Visible = false;
            ucReports1.Visible = false;
            settings1.Visible = false;
            help1.Visible = false;
        }
        
        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            //ucDashboard1.Visible = true;
            ucRegistration1.Visible = false;
            ucBooks1.Visible = false;
            ebooks1.Visible = false;
            ucReports1.Visible = false;
            settings1.Visible = false;
            help1.Visible = false;
        }

        private void btn_registration_click(object sender, EventArgs e)
        {
            //ucDashboard1.Visible = false;
            ucRegistration1.Visible = true;
            ucBooks1.Visible = false;
            ebooks1.Visible = false;
            ucReports1.Visible = false;
            settings1.Visible = false;
            help1.Visible = false;
        }

        private void subMenu1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ebooks_Click(object sender, EventArgs e)
        {
            //ucDashboard1.Visible = false;
            ucRegistration1.Visible = false;
            ucBooks1.Visible = false;
            ebooks1.Visible = true;
            ucReports1.Visible = false;
            settings1.Visible = false;
            help1.Visible = false;
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            //ucDashboard1.Visible = false;
            ucRegistration1.Visible = false;
            ucBooks1.Visible = true;
            ebooks1.Visible = false;
            ucReports1.Visible = false;
            settings1.Visible = false;
            help1.Visible = false;
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            //ucDashboard1.Visible = false;
            ucRegistration1.Visible = false;
            ucBooks1.Visible = false;
            ebooks1.Visible = false;
            ucReports1.Visible = true;
            settings1.Visible = false;
            help1.Visible = false;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            //ucDashboard1.Visible = false;
            ucRegistration1.Visible = false;
            ucBooks1.Visible = false;
            ebooks1.Visible = false;
            ucReports1.Visible = false;
            settings1.Visible = true;
            help1.Visible = false;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            //ucDashboard1.Visible = false;
            ucRegistration1.Visible = false;
            ucBooks1.Visible = false;
            ebooks1.Visible = false;
            ucReports1.Visible = false;
            settings1.Visible = false;
            help1.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login loginPage = new login();
            loginPage.Show();
            this.Hide();
        }

        private void help1_Load(object sender, EventArgs e)
        {

        }
    }
}
