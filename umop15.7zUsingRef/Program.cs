using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop15o7zUsingRef
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteAllNumbersFromText("6 8 9    3 56                   874     7699");
            Console.ReadKey();
        }

        public static void SkipSpaces(string text, ref int pos)
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
        }
        public static string ReadNumber(string text, ref int pos)
        {
            var start = pos;
            while (pos < text.Length && char.IsDigit(text[pos]))
                pos++;
            return text.Substring(start, pos - start);
        }
        public static void WriteAllNumbersFromText(string text)
        {
            int pos = 0;
            while (true)
            {
                SkipSpaces(text, ref pos);
                var num = ReadNumber(text, ref pos);
                if (num == "") break;
                Console.WriteLine("позиция "+pos+"   "+ "число " + num + " ");
            }
            Console.WriteLine();
        }
    }
}
