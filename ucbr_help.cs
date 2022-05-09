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
    public partial class ucbr_help : UserControl
    {
        public ucbr_help()
        {
            InitializeComponent();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            feedbackform sendfb = new feedbackform();
            sendfb.Show();
        }
    }
}
