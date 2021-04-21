using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop13o15zCounterClockWise
{
    class Program
    {
		private static void Main()
		{
			var array = new[]
			{
			new Point { X = 1, Y = 0 },
			new Point { X = -1, Y = 0 },
			new Point { X = 0, Y = 1 },
			new Point { X = 0, Y = -1 },
			new Point { X = 0.01, Y = 1 }
			};
			Array.Sort(array, new ClockwiseComparer());
			foreach (Point e in array)
				Console.WriteLine("{0} {1}", e.X, e.Y);
			Console.ReadKey();
		}

		public class Point
		{
			public double X;
			public double Y;
		}

		public class ClockwiseComparer : IComparer
		{
			public int Compare(object x, object y)
			{
				Point p1 = (Point)x;
				Point p2 = (Point)y;
				return Math.Atan2(-p1.Y, -p1.X).CompareTo(Math.Atan2(-p2.Y, -p2.X));
			}
		}
	}
}
