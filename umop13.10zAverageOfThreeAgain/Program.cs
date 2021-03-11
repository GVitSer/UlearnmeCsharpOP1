using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop13o10zAverageOfThreeAgain
{
    class Program
    {
		public static void Main()
		{
			Console.WriteLine(MiddleOfThree(2, 5, 4));
			Console.WriteLine(MiddleOfThree(3, 1, 2));
			Console.WriteLine(MiddleOfThree(3, 5, 9));
			Console.WriteLine(MiddleOfThree("B", "Z", "A"));
			Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
			Console.ReadKey();
		}

		static object MiddleOfThree(object a, object b, object c)
		{
			var comElem1 = (IComparable)a;
			var comElem2 = (IComparable)b;
			if (comElem1.CompareTo(c)*comElem1.CompareTo(b) == -1) return a;
			else if (comElem2.CompareTo(c) * comElem2.CompareTo(a) == -1) return b;
			else return c;
		}
	}
}
