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
    public partial class uco_settings : UserControl
    {
        public uco_settings()
        {
            InitializeComponent();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            feedbackform sendfdback = new feedbackform();
            sendfdback.Show();
        }
    }
}
