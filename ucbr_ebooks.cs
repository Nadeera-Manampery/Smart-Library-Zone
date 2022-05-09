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
    public partial class ucbr_ebooks : UserControl
    {
        public ucbr_ebooks()
        {
            InitializeComponent();
        }

        private void btnRemoveEBooks_Click(object sender, EventArgs e)
        {
            removeEbooks ebookRem = new removeEbooks();
            ebookRem.Show();
        }

        private void btnAvailableEBooks_Click(object sender, EventArgs e)
        {
            AvailableEBooks ebookAvailable = new AvailableEBooks();
            ebookAvailable.Show();
        }
    }
}
