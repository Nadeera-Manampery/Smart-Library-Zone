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
    public partial class uco_registration : UserControl
    {
        public uco_registration()
        {
            InitializeComponent();
        }

        private void btnMemberReg_Click(object sender, EventArgs e)
        {
            MemberRegistration reader = new MemberRegistration();
            reader.Show();
        }
    }
}
