using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop13o7zPrintEveryone
{
    class Program
    {
        public static void Print(params object[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Print(1, 2);
            Print("a", 'b');
            Print(1, "a");
            Print(true, "a", 1);
            Console.ReadKey();
        }
    }
}
