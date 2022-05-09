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
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void btnBookCategories_Click(object sender, EventArgs e)
        {

        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            QrEmployee qr = new QrEmployee();
            qr.ShowDialog();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            feedbackform sendfdback = new feedbackform();
            sendfdback.Show();
        }
    }
}
