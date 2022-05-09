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
    public partial class ucbr_settings : UserControl
    {
        public ucbr_settings()
        {
            InitializeComponent();
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            brEmpQr empQr = new brEmpQr();
            empQr.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            feedbackform sendfdback = new feedbackform();
            sendfdback.Show();
        }
    }
}
