using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookEC
{
    public class Book
    {
        private int activePage;
        private List<int> bookmarks;
        private string title;
        private string author;
        private int pageCount;
        private List<string> pages;

        public Book(int _activePage, List<int> _bookmarks, string _title, string _author, int _pageCount, List<string> _pages)
        {
            activePage = _activePage;
            bookmarks = _bookmarks;
            title = _title;
            author = _author;
            pageCount = _pageCount;
            pages = _pages;
        }

        public void NextPage()
        {
            if (activePage < pageCount - 1) activePage++;
        }

        public void PreviousPage()
        {
            if (activePage > 0) activePage--;
        }

        public void AddBookmark()
        {
            if (bookmarks.Count < 5)
            {
                bookmarks.Add(activePage);
            }
        }

        public void RemoveBookmark()
        {
            if (bookmarks.Contains(activePage))
            {
                bookmarks.Remove(activePage);
            }
        }

        public override string ToString()
        {
            string str = "" + activePage;
            for (int i = 0; i < 5; i++)
            {
                if (i < bookmarks.Count)
                {
                    str = str + "\n" + bookmarks[i];
                }
                else
                {
                    str = str + "\n-1";
                }
            }
            str = str + "\n" + title;
            str = str + "\n" + author;
            str = str + "\n" + pageCount;
            foreach (string page in pages)
            {
                str = str + "\n" + page;
            }
            return str;
        }

        public int GetActivePageNumber()
        {
            return activePage + 1;
        }

        public string GetPage()
        {
            return pages[activePage];
        }

        public bool IsPageBookmarked()
        {
            return bookmarks.Contains(activePage);
        }

        public int GetLength()
        {
            return pageCount;
        }

        public void SetActivePage(int index)
        {
            if(index >= 0 && index < pageCount)
            {
                activePage = index;
            }
        }
    }
}
