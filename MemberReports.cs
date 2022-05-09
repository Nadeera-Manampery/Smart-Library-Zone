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
    public partial class MemberReports : Form
    {
        public MemberReports()
        {
            InitializeComponent();
        }

        private void btnMemberAll_Click(object sender, EventArgs e)
        {
            MemberReport memberReport = new MemberReport();
            this.Hide();
            memberReport.Show();
        }

        private void btnMmberBranch_Click(object sender, EventArgs e)
        {
            MemberReportByBranch branchmemberReport = new MemberReportByBranch();
            this.Hide();
            branchmemberReport.Show();
        }

        private void btnMemberDate_Click(object sender, EventArgs e)
        {
            MemberReportByDate memberReportByDate = new MemberReportByDate();
            this.Hide();
            memberReportByDate.Show();
        }
    }
}
