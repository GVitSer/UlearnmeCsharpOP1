using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop5._3zMaximumIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] array= new[] { 1.0, 2.8, 3, 10, 18, 10, 2, 18 };
            Console.WriteLine(Min(array));
            Console.WriteLine(MaxIndex(array));
            Console.ReadKey();
        }
        static double Min(double[] array)
        {
            var min = double.MaxValue;
            foreach (var item in array)
                if (item < min) min = item;
            return min;
        }
        public static int MaxIndex(double[] array)
        {
            double max = 0;
            int indexMax=-1;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }
    }
}
