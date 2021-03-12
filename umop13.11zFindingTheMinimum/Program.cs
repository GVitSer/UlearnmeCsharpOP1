using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop13o11zFindingTheMinimum
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
            Console.ReadKey();
        }

        public static object Min (Array array)
        {
            var min = (IComparable)array.GetValue(0);
            for (int i=1; i<array.Length; i++)
            {
                var e1 = (IComparable)array.GetValue(i);
                if (e1.CompareTo(min) < 0)
                    min = e1;
            }
            return min;
        }
    }
}