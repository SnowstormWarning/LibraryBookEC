using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryBookEC
{
    class Controller
    {
        private List<Book> library = new List<Book>();
        public ShowBookViewDelegate showBookView;

        public Book GetBook(int index)
        {
            return library[index];
        }

        public List<Book> GetLibrary()
        {
            return library;
        }

        public List<Book> SyncLibrary()
        {
            library.Clear();
            using (StreamReader reader = new StreamReader(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/booksCloud.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int activePage = Int32.Parse(reader.ReadLine());
                    List<int> bookmarks = new List<int>();
                    for (int i = 0; i < 5; i++)
                    {
                        int bookmark = Int32.Parse(reader.ReadLine());
                        if (bookmark != -1)
                        {
                            bookmarks.Add(bookmark);
                        }
                    }
                    string title = reader.ReadLine();
                    string author = reader.ReadLine();
                    int maxPages = Int32.Parse(reader.ReadLine());
                    List<string> pages = new List<string>();
                    for (int i = 0; i < maxPages; i++)
                    {
                        pages.Add(reader.ReadLine());
                    }
                    library.Add(new Book(activePage, bookmarks, title, author, maxPages, pages));
                }
            }
            return GetLibrary();
        }

        public void UploadLibrary()
        {
            using (StreamWriter writer = new StreamWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/booksCloud.txt"))
            {
                foreach (Book book in library)
                {
                    writer.WriteLine(book.ToString());
                }
            }
        }

        public void OpenBook(int index)
        {
            showBookView(library[index]);
        }

        public Book NextPage(Book book)
        {
            book.NextPage();
            return book;
        }

        public Book PreviousPage(Book book)
        {
            book.PreviousPage();
            return book;
        }

        public Book GotoPage (Book book, int index)
        {
            book.SetActivePage(index);
            return book;
        }

        public Book AddBookmark(Book book)
        {
            book.AddBookmark();
            return book;
        }

        public Book RemoveBookmark(Book book)
        {
            book.RemoveBookmark();
            return book;
        }
    }
}
