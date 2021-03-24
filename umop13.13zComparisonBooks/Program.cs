using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop13o13zComparisonBooks
{
    class Program
    {
        class Book : IComparable
        {
            public string Title;
            public int Theme;

            public int CompareTo(object obj)
            {
                var book = (Book)obj;
                int themeCompare = Theme.CompareTo(book.Theme);
                if (themeCompare != 0) return themeCompare;
                return Title.CompareTo(book.Title);
            }
        }
        static void Main(string[] args)
        {
            var book1 = new Book { Title = "Axe", Theme = 4 };
            var book2 = new Book { Title = "Age", Theme = 8 };
            Console.WriteLine(book1.CompareTo(book2));
            Console.ReadKey();
        }
    }
}
