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
    public partial class uco_reports : UserControl
    {
        public uco_reports()
        {
            InitializeComponent();
        }

        private void btnMemberRep_Click(object sender, EventArgs e)
        {
            MemberReportByBranch memberReportByBranch = new MemberReportByBranch();
            memberReportByBranch.Show();
        }

        private void btnBookSum_Click(object sender, EventArgs e)
        {
            BookReportByBranch bookReportByBranch = new BookReportByBranch();
            bookReportByBranch.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            MemberAttendanceReportToOfficer attendanceReportToOfficer = new MemberAttendanceReportToOfficer();
            attendanceReportToOfficer.Show();
        }
    }
}
