using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookEC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Library lib = new Library();
            BookView bookView = new BookView();
            Controller controller = new Controller();
            //DELEGATES FOR LIBRARY
            lib.syncLibrary = controller.SyncLibrary;
            lib.uploadLibrary = controller.UploadLibrary;
            lib.openBook = controller.OpenBook;
            //
            //DELEGATES FOR BOOKVIEW
            bookView.previousPage = controller.PreviousPage;
            bookView.nextPage = controller.NextPage;
            bookView.removeBookmark = controller.RemoveBookmark;
            bookView.addBookmark = controller.AddBookmark;
            bookView.gotoPage = controller.GotoPage;
            //
            //DELEGATES FOR CONTROLLER
            controller.showBookView = bookView.OpenBookView;
            Application.EnableVisualStyles();
            Application.Run(lib);
        }
    }
}
