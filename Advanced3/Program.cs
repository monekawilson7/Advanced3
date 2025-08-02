using System;

namespace Advanced3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book myBook = new Book(
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
            Console.WriteLine(myBook.ToString());
            #endregion

        }
    }
}
