using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
    }

    public static class Geometry
    {
        public static Vector
            V1 = new Vector { X = 3.2, Y = 8.5 },
            V2 = new Vector { X = 120.1, Y = 3.4 },
            VSum = new Vector { X = 0, Y = 0 };
        public static double DlinaV, S;
        public static double GetLength(Vector v1)
        {
            S = v1.X * v1.X + v1.Y * v1.Y;
            if (S > 0)
            {
                return DlinaV = Math.Sqrt(S);
            }
            else return 0;
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            VSum.X = v1.X + v2.X;
            VSum.Y = v1.Y + v2.Y;
            return VSum;
        }
    }
}