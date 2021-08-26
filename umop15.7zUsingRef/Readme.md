Using ref

This task demonstrates one of the rare cases where ref is appropriate.

SkipSpaces skips all whitespace characters in text, starting at position pos. At the end, pos is set to the first non-whitespace character.


public static void SkipSpaces(string text, ref int pos)
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
        }


ReadNumber skips all digits in text, starting at position pos, and then returns all missing characters. At the end, pos is set to the first non-digit character.


 {
            var start = pos;
            while (pos < text.Length && char.IsDigit(text[pos]))
                pos++;
            return text.Substring(start, pos - start);
        }


Add a function that reads all numbers from a string and prints them, separated by a single space.


        public static void WriteAllNumbersFromText(string text)
        {
            while (true)
            {
                // skip spaces
                var num = // read next number
                if (num == "") break;
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


Code:

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

