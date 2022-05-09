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
    public partial class Officer : Form
    {
        public string receiveUser;
        public Officer()
        {
            InitializeComponent();
        }

        private void Officer_Load(object sender, EventArgs e)
        {
            lblUser.Text = receiveUser;
            //uco_dashboard1.Visible = true;
            uco_registration1.Visible = false;
            uco_books1.Visible = false;
            uco_members1.Visible = false;
            uco_reports1.Visible = false;
            uco_settings1.Visible = false;
            uco_help1.Visible = false;
        }
        
        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            //uco_dashboard1.Visible = true;
            uco_registration1.Visible = false;
            uco_books1.Visible = false;
            uco_members1.Visible = false;
            uco_reports1.Visible = false;
            uco_settings1.Visible = false;
            uco_help1.Visible = false;
        }

        private void btn_books_Click_1(object sender, EventArgs e)
        {
            //uco_dashboard1.Visible = false;
            uco_registration1.Visible = false;
            uco_books1.Visible = true;
            uco_members1.Visible = false;
            uco_reports1.Visible = false;
            uco_settings1.Visible = false;
            uco_help1.Visible = false;
        }

        private void btn_registration_Click_1(object sender, EventArgs e)
        {
            //uco_dashboard1.Visible = false;
            uco_registration1.Visible = true;
            uco_books1.Visible = false;
            uco_members1.Visible = false;
            uco_reports1.Visible = false;
            uco_settings1.Visible = false;
            uco_help1.Visible = false;
        }

        private void btn_Members_Click_1(object sender, EventArgs e)
        {
            //uco_dashboard1.Visible = false;
            uco_registration1.Visible = false;
            uco_books1.Visible = false;
            uco_members1.Visible = true;
            uco_reports1.Visible = false;
            uco_settings1.Visible = false;
            uco_help1.Visible = false;
        }

        private void btn_reports_Click_1(object sender, EventArgs e)
        {
            //uco_dashboard1.Visible = false;
            uco_registration1.Visible = false;
            uco_books1.Visible = false;
            uco_members1.Visible = false;
            uco_reports1.Visible = true;
            uco_settings1.Visible = false;
            uco_help1.Visible = false;
        }

        private void btn_settings_Click_1(object sender, EventArgs e)
        {
            //uco_dashboard1.Visible = false;
            uco_registration1.Visible = false;
            uco_books1.Visible = false;
            uco_members1.Visible = false;
            uco_reports1.Visible = false;
            uco_settings1.Visible = true;
            uco_help1.Visible = false;
        }

        private void btn_help_Click_1(object sender, EventArgs e)
        {
            //uco_dashboard1.Visible = false;
            uco_registration1.Visible = false;
            uco_books1.Visible = false;
            uco_members1.Visible = false;
            uco_reports1.Visible = false;
            uco_settings1.Visible = false;
            uco_help1.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login loginPage = new login();
            loginPage.Show();
            this.Hide();
        }
    }
}
