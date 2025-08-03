using System;
using System.Collections.Generic;

namespace Advanced3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* Book myBook = new Book(
                 "93-86954-21-4",
                 "C#",
                 new string[] { " Andrew Hunt" },
                 new DateTime(2010,2,5),
                 250
                 );
             Console.WriteLine(myBook.ToString());
             Console.WriteLine(BookFunctions.GetTitle(myBook));
             Console.WriteLine(BookFunctions.GetAuthors(myBook));
             Console.WriteLine(BookFunctions.GetPrice(myBook));
             Console.WriteLine(myBook.ToString());*/
            #endregion
            #region Q2 a
            List<Book> books = new List<Book>()
            {
                new Book("1", "programming", new string[] { "Author1" }, new DateTime(2000, 1, 1), 100),
                new Book("2", "DataBase", new string[] { "Author2" }, new DateTime(2010, 1, 1), 200)
            };
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            #endregion

            #region Q2 b
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            #endregion
            #region Q2 c
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });
            #endregion
            #region Q2 D
            LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToShortDateString());
            #endregion
        }
    }
}
