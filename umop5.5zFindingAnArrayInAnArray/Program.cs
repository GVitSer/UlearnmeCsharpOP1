using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop5o5zFindingAnArrayInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 3, 4 };
            int[] subArray = { 3, 4 };
            Console.WriteLine(FindSubarrayStartIndex(array, subArray));
            Console.ReadKey();
        }
        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }
        public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
        {
            bool real=true;
            for (int j = 0; j < subArray.Length; j++)
            {
                if (array[j + i] == subArray[j])
                    real = true;
                else
                {
                    real = false; break;
                }
            }
            return real;
        }
    }
}
