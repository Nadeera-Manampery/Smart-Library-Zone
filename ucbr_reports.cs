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
    public partial class ucbr_reports : UserControl
    {
        public ucbr_reports()
        {
            InitializeComponent();
        }

        private void btnOfficerRep_Click(object sender, EventArgs e)
        {
            officerReport officer = new officerReport();
            officer.Show();
        }

        private void btnBookSum_Click(object sender, EventArgs e)
        {
            bookReport book = new bookReport();
            book.Show();
        }

        private void btnMemberRep_Click(object sender, EventArgs e)
        {
            memberReportUsingBrid memberReportUsingBrid = new memberReportUsingBrid();
            memberReportUsingBrid.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            MemberAttendanceReport memberAttendanceReport = new MemberAttendanceReport();
            memberAttendanceReport.Show();
        }
    }
}
