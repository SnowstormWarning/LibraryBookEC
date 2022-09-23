using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookEC
{
    public partial class BookView : Form
    {
        public NextPageDelegate nextPage;
        public PreviousPageDelegate previousPage;
        public RemoveBookmarkDelegate removeBookmark;
        public AddBookmarkDelegate addBookmark;
        public GotoPageDelegate gotoPage;
        private Book book;
        public BookView()
        {
            InitializeComponent();
        }

        private void RefreshBook()
        {
            UpDown.Value = book.GetActivePageNumber();
            UpDown.Maximum = book.GetLength();
            TextBox.Text = book.GetPage();
            if (book.IsPageBookmarked())
            {
                RemoveBookmarkButton.Enabled = true;
                AddBookmarkButton.Enabled = false;
            }
            else
            {
                RemoveBookmarkButton.Enabled = false;
                AddBookmarkButton.Enabled = true;
            }
            if (UpDown.Value == 1)
            {
                PreviousPageButton.Enabled = false;
                NextPageButton.Enabled = true;
            }
            else if (UpDown.Value == book.GetLength())
            {
                PreviousPageButton.Enabled = true;
                NextPageButton.Enabled = false;
            }
            else
            {
                PreviousPageButton.Enabled = true;
                NextPageButton.Enabled = true;
            }
        }

        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            book = previousPage(book);
            RefreshBook();
        }

        private void NextPageButton_Click(object sender, EventArgs e)
        {
            book = nextPage(book);
            RefreshBook();
        }

        private void RemoveBookmarkButton_Click(object sender, EventArgs e)
        {
            book = removeBookmark(book);
            RefreshBook();
        }

        private void AddBookmarkButton_Click(object sender, EventArgs e)
        {
            book = addBookmark(book);
            RefreshBook();
        }

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Value <= ((NumericUpDown)sender).Maximum && ((NumericUpDown)sender).Value > ((NumericUpDown)sender).Minimum) gotoPage(book,(int)((NumericUpDown)sender).Value-1);
            RefreshBook();
        }

        public void OpenBookView(Book book)
        {
            this.book = book;
            RefreshBook();
            Show();
        }

        private void BookView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
