using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop5._2zEvenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFirstEvenNumbers(10);
            Console.ReadKey();
        }
        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] array = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 2 * (i + 1);
                Console.WriteLine(array[i]);
            }
            return array;
        }
    }
}
