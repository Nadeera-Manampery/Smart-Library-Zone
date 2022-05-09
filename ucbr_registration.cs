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
    public partial class ucbr_registration : UserControl
    {
        public ucbr_registration()
        {
            InitializeComponent();
        }

        private void btnOfficerRegistration_Click(object sender, EventArgs e)
        {
            OfficerRegistration officer = new OfficerRegistration();
            officer.Show();
        }

        private void btnMemberRegistration_Click(object sender, EventArgs e)
        {
            MemberRegistration reader = new MemberRegistration();
            reader.Show();
        }
    }
}
