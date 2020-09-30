using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop6o2StrangersCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("strzap.txt");
            Console.WriteLine(content);
            string[] lines = content.Split(' ');
            //foreach (var e in lines)
            //    Console.WriteLine(e);
            Console.WriteLine();
            Console.WriteLine(DecodeMessage(lines));
            Console.ReadKey();
        }
        private static string DecodeMessage(string[] lines)
        {
            List<string> listBig = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (char.IsUpper(lines[i][0]))
                    listBig.Add(lines[i]);
            }
            listBig.Reverse();
            return String.Join(" ", listBig);
        }
    }
}