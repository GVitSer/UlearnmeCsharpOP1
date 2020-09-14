using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop4d8zChessBoard
{
    class Program
    {
		public static void Main()
		{
			WriteBoard(8);
			WriteBoard(1);
			WriteBoard(2);
			WriteBoard(3);
			WriteBoard(10);
		}
        private static void WriteBoard(int size)
        {
            string l1, l2, s1 = "#", s2 = ".";
            for (int j = 0; j < size; j++)
            {
                if (j % 2 == 0)
                {
                    l1 = s1; l2 = s2;
                }
                else
                {
                    l1 = s2; l2 = s1;
                }
                for (int i = 0; i < size; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(l1);
                    else
                        Console.Write(l2);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
