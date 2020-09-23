using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop5o12RaiseAnArrayToAPower
{
    class Program
    {
        public static void Main()
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Метод PrintArray уже написан за вас
            PrintArray(GetPoweredArray(arrayToPower, 1));

            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            PrintArray(GetPoweredArray(arrayToPower, 2));
            PrintArray(GetPoweredArray(arrayToPower, 3));

            // не забывайте про частные случаи:
            PrintArray(GetPoweredArray(new int[0], 1));
            PrintArray(GetPoweredArray(new[] { 42 }, 0));
            Console.ReadKey();
        }
        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] arrp = new int[arr.Length];
            for (int i=0;i< arr.Length;i++)
            {
                arrp[i] = (int)Math.Pow(arr[i], power);
            }
            return arrp;
        }
        public static void PrintArray (int[] arrp)
        {
            for (int i = 0; i < arrp.Length; i++)
            {
                Console.Write(arrp[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
