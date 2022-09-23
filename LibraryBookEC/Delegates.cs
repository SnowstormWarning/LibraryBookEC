using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBookEC
{
    //DELEGATES FILE
    public delegate void ShowBookViewDelegate(Book book);
    public delegate List<Book> SyncLibraryDelegate();
    public delegate void UploadLibraryDelegate();
    public delegate void OpenBookDelegate(int index);
    public delegate Book PreviousPageDelegate(Book book);
    public delegate Book NextPageDelegate(Book book);
    public delegate Book RemoveBookmarkDelegate(Book book);
    public delegate Book AddBookmarkDelegate(Book book);
    public delegate Book GotoPageDelegate(Book book, int index);
}
