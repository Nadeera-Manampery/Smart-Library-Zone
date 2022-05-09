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
    public partial class uco_books : UserControl
    {
        public uco_books()
        {
            InitializeComponent();
        }

        private void btnAddnewBooks_Click(object sender, EventArgs e)
        {
            AddBooks bookAdd = new AddBooks();
            bookAdd.Show();
        }

        private void btnRemoveBooks_Click(object sender, EventArgs e)
        {
            removeBook remBook = new removeBook();
            remBook.Show();
        }

        private void btnAvailableBooks_Click(object sender, EventArgs e)
        {
            viewAvailableBooks availableBooks = new viewAvailableBooks();
            availableBooks.Show();
        }

        private void btnCreateQr_Click(object sender, EventArgs e)
        {
            excludeBooks exBooks = new excludeBooks();
            exBooks.Show();
        }

        private void btnBookIssue_Click(object sender, EventArgs e)
        {
            check_eligibility check_Eligibility = new check_eligibility();
            check_Eligibility.Show();
        }

        private void btnBookReceive_Click(object sender, EventArgs e)
        {
            bookReceiving receiving = new bookReceiving();
            receiving.Show();
        }
    }
}
