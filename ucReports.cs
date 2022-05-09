using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_zone
{
    public partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();
        }

        private void btnMemberRep_Click(object sender, EventArgs e)
        {
            MemberReports memberReports = new MemberReports();
            memberReports.Show();
        }

        private void btnEbookReport_Click(object sender, EventArgs e)
        {
            ebookReport ebookReport = new ebookReport();
            ebookReport.Show();
                 
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            bookReport bookReport = new bookReport();
            bookReport.Show();
        }

        private void btnBrAdminRep_Click(object sender, EventArgs e)
        {
            brAdminReport brAdmin = new brAdminReport();
            brAdmin.Show();
        }

        private void btnOfficerRep_Click(object sender, EventArgs e)
        {
            officerReport officerReport = new officerReport();
            officerReport.Show();
        }
    }
}
