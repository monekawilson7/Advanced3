using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced3
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookFunctionDelegate fptr) {
            foreach (Book book in bList) {
                Console.WriteLine(fptr(book));
            }
        }
    }
}
