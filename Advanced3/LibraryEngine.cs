using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced3
{
    public class LibraryEngine
    {
        //a
/*        public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fptr) {
            foreach (Book book in bList) {
                Console.WriteLine(fptr(book));
            }
        }*/

        //b
        public static void ProcessBooks(List<Book> bList, Func<Book, String> fptr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fptr(book));
            }
        }

        internal static void ProcessBooks(object books, Func<Book, string> getAuthors)
        {
            throw new NotImplementedException();
        }
    }
}
