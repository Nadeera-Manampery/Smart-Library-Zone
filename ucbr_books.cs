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
    public partial class ucbr_books : UserControl
    {
        public ucbr_books()
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

        private void btnExcludeBookList_Click(object sender, EventArgs e)
        {
            excludeBooks exBooks = new excludeBooks();
            exBooks.Show();
        }
    }
}
