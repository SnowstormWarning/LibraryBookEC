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
    public partial class Library : Form
    {
        public SyncLibraryDelegate syncLibrary;
        public UploadLibraryDelegate uploadLibrary;
        public OpenBookDelegate openBook;

        public Library()
        {
            InitializeComponent();
        }

        private void SyncLibraryButton_Click(object sender, EventArgs e)
        {
            BookListBox.DataSource = null;
            BookListBox.DataSource = syncLibrary();
        }

        private void UploadLibraryButton_Click(object sender, EventArgs e)
        {
            uploadLibrary();
        }

        private void OpenBookButton_Click(object sender, EventArgs e)
        {
            if(BookListBox.SelectedIndex != -1)
            {
                openBook(BookListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No Book Selected to Open!");
            }
        }
    }
}
