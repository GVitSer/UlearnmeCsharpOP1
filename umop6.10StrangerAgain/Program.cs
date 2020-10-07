using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop6o10StrangerAgain
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] commands=new string[6];
			commands[0] = "push Привет! Это снова я! Пока!";
			commands[1] = "pop 5";
			commands[2] = "push Как твои успехи? Плохо?";
			commands[3] = "push qwertyuiop";
			commands[4] = "push 1234567890";
			commands[5] = "pop 26";
			Console.WriteLine(ApplyCommands(commands));
			Console.ReadKey();
		}
		private static string ApplyCommands(string[] commands)
		{
			var builder = new StringBuilder();
			foreach (var stroka in commands)
			{
				string[] words;
				words = stroka.Split(' ');
				if (words[0] == "push")
					builder.Append(stroka.Substring(5, stroka.Length - 5));
				else if (words[0] == "pop")
					builder.Remove(builder.Length - int.Parse(words[1]), int.Parse(words[1]));
			}
			return builder.ToString();
		}
	}
}
