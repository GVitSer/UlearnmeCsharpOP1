using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class QuadricEquation
    {
        public static double[] Solve (double a, double b, double c)
        {
            if (a == 0)
                return new double[] { -c / b };

            var squareOfDisc = Math.Sqrt(b * b - 4 * a * c);
            if (double.IsNaN(squareOfDisc))
                return new double[0];
            if (squareOfDisc == 0)
                return new double[] { -b / (2 * a) };
            return new[]
            {
                (- b + squareOfDisc)/(2*a),
                (- b - squareOfDisc)/(2*a)
            };
        }
    }
}