using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop5o7zTarotCards
{
    class Program
    {
		enum Suits
		{
			Wands,
			Coins,
			Cups,
			Swords
		}
        private static string GetSuit(Suits suit)
        {
            return new string[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];
        }

        public static void Main()
		{
			Console.WriteLine(GetSuit(Suits.Wands));
			Console.WriteLine(GetSuit(Suits.Coins));
			Console.WriteLine(GetSuit(Suits.Cups));
			Console.WriteLine(GetSuit(Suits.Swords));
			Console.ReadKey();
		}
	}
}
