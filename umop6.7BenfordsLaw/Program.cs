using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop6o7BenfordsLaw
{
    class Program
    {
        public static void Main()
        {
            string tallestBuildings = File.ReadAllText("tallestB.txt");
            PrintNumbers(GetBenfordStatistics("1"));
            PrintNumbers(GetBenfordStatistics("abc"));
            PrintNumbers(GetBenfordStatistics("123 456 789"));
            PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            PrintNumbers(GetBenfordStatistics(tallestBuildings));
            Console.ReadKey();
        }
        public static void PrintNumbers(int[] statistics)
        {
            foreach (var e in statistics)
            Console.Write(e+" ");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static int[] GetBenfordStatistics(string text)
        {
            List<int> digits = new List<int>();
            var statistics = new int[10];
            if (char.IsDigit(text[0]))
            {
                digits.Add(text[0] - '0');
            }
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) & !char.IsDigit(text[i - 1]))
                {
                    digits.Add(text[i]-'0');
                }   
            }
            foreach (var e in digits)
                Console.Write(e+" ");
            Console.WriteLine();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    if (j+1== digits[i])
                    {
                        statistics[j]++;
                    }
                }
            }
            return statistics;
        }
    }
}
