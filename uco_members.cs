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
    public partial class uco_members : UserControl
    {
        public uco_members()
        {
            InitializeComponent();
        }

        private void uco_members_Load(object sender, EventArgs e)
        {

        }

        private void btnClosing_Click(object sender, EventArgs e)
        {
            cancelMembership accClose = new cancelMembership();
            accClose.Show();
        }

        private void btnMemberQr_Click(object sender, EventArgs e)
        {
            MemberQr memberQr = new MemberQr();
            memberQr.Show();
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            resetMemberPassword resetMember = new resetMemberPassword();
            resetMember.Show();
        }
    }
}
