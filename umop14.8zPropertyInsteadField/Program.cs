using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop14o8zPropertyInsteadField
{
    class Program
    {
        static void Main(string[] args)
        {
            Check();
            Console.ReadKey();
        }
        public static void Check()
        {
            var book = new Book();
            book.Title = "Structure and interpretation of computer programs";
            Console.WriteLine(book.Title);
        }
        public class Book
        {
            public string Title { get; set;}
        }
    }
}
