using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_zone
{
    public partial class BranchAdministrator : Form
    {
        public string receiveUser;
        public BranchAdministrator()
        {
            InitializeComponent();
        }

        private void BranchAdministrator_Load(object sender, EventArgs e)
        {
            lblUser.Text = receiveUser;
            //ucbr_dashboard1.Visible = true;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;

            
        }
        
        private void btn_settings_Click(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = false;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = true;
            ucbr_help1.Visible = false;
        }

        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = true;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        private void btn_registration_Click_1(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = false;
            ucbr_registration1.Visible = true;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        private void btn_books_Click_1(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = false;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = true;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        private void btn_ebooks_Click_1(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = false;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = true;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        private void btn_reports_Click_1(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = false;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = true;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        private void btn_Accounts_Click_1(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = false;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = true;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        private void btn_help_Click_1(object sender, EventArgs e)
        {
            //ucbr_dashboard1.Visible = false;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login loginPage = new login();
            loginPage.Show();
            this.Hide();
        }

        private void ucbr_help1_Load(object sender, EventArgs e)
        {

        }
    }
}
