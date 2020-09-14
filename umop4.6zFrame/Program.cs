using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop4d6zFrame
{
    class Program
    {
		public static void Main()
		{
			WriteTextWithBorder("Menu:");
			WriteTextWithBorder("");
			WriteTextWithBorder(" ");
			WriteTextWithBorder("Game Over!");
			WriteTextWithBorder("Select level:");
			Console.ReadKey();
		}
		private static void WriteTextWithBorder(string text)
		{
			Console.Write("+");
			for (int i = 0; i < text.Length+2; i++)
				Console.Write("-");
			Console.WriteLine("+");
			Console.Write("| ");
			Console.Write(text);
			Console.WriteLine(" |");
			Console.Write("+");
			for (int i = 0; i < text.Length + 2; i++)
				Console.Write("-");
			Console.WriteLine("+");
		}
	}
}
