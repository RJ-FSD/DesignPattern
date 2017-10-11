using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationPatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book { Name = "Around the World in 80 Days" });
            bookShelf.AppendBook(new Book { Name = "Bible" });
            bookShelf.AppendBook(new Book { Name = "Cinderella" });
            bookShelf.AppendBook(new Book { Name = "Daddy-Long-Legs" });
            foreach (var book in bookShelf.GetEnumerable())
            {
                Console.WriteLine(book.Name);
            }
            Console.ReadLine();
        }
    }
}
