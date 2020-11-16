using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			var x = 1.0;
			var y = 0.0;
			var angle45 = Math.PI * 45 / 180;
			var angle135 = Math.PI * 135 / 180;
			var random = new Random(seed);
			for (int i = 0; i < iterationsCount; i++)
			{
				var nextNumber = random.Next(1, 3);
				if (nextNumber == 1)
				{
					var x1 = DrawX(x, y, angle45);
					var y1 = DrawY(x, y, angle45);
					x = x1;
					y = y1;
				}
				if (nextNumber == 2)
				{
					var x1 = DrawX(x, y, angle135) + 1;
					var y1 = DrawY(x, y, angle135);
					x = x1;
					y = y1;
				}
				pixels.SetPixel(x, y);
			}
		}
		public static double DrawX(double a, double b, double angle)
		{
			var x1 = (a * Math.Cos(angle) - b * Math.Sin(angle)) / Math.Sqrt(2);
			return x1;
		}
		public static double DrawY(double a, double b, double angle)
		{
			var y1 = (a * Math.Sin(angle) + b * Math.Cos(angle)) / Math.Sqrt(2);
			return y1;
		}
	}
}