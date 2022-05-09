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
    public partial class ucRegistration : UserControl
    {
        public ucRegistration()
        {
            InitializeComponent();
        }

        private void btnBranchAdminRegistration_Click(object sender, EventArgs e)
        {
            BAregistration brAdmin = new BAregistration();
            brAdmin.Show();
        }

        private void btnOfficerRegistration_Click(object sender, EventArgs e)
        {
            OfficerRegistration regOfficer = new OfficerRegistration();
            regOfficer.Show();
        }
    }
}
