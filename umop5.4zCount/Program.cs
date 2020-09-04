using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop5o4zCount
{
    class Program
    {
        public static int GetElementCount(int[] items, int itemToCount)
        {
            int count = 0;
            for (int i=0;i<items.Length;i++)
            {
                if (items[i] == itemToCount)
                    count++;
            }
            return count;
        }
        static void Main()
        {
            int[] items = { 1, 2, 1, 1 };
            Console.WriteLine(GetElementCount(items, 1));
            Console.ReadKey();
        }
    }
}
