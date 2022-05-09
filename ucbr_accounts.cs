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
    public partial class ucbr_accounts : UserControl
    {
        public ucbr_accounts()
        {
            InitializeComponent();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Edit_Profile edit_Profile = new Edit_Profile();
            this.Hide();
            edit_Profile.Show();
        }

        private void btnUpdateMmember_Click(object sender, EventArgs e)
        {
            updateMember upMember = new updateMember();
            this.Hide();
            upMember.Show();
        }

        private void btnUpOfficer_Click(object sender, EventArgs e)
        {
            updateOfficer upOfficer = new updateOfficer();
            this.Hide();
            upOfficer.Show();
        }
    }
}
