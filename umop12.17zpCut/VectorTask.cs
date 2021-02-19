using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
    }

    public class Segment
    {
        public Vector Begin;
        public Vector End;
    }

    public static class Geometry
    {
        public static Vector
            VSum = new Vector { X = 0, Y = 0 };
        public static Segment
            Sg = new Segment
            {
                Begin = new Vector { X = 0, Y = 0 },
                End = new Vector { X = 1, Y = 1 }
            };
        public static double DlinaV, S, S1;
        public static bool B = false;
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

        public static double GetLength(Segment sgm)
        {
            S1 = (sgm.End.X - sgm.Begin.X) * (sgm.End.X - sgm.Begin.X) + 
                (sgm.End.Y - sgm.Begin.Y) * (sgm.End.Y - sgm.Begin.Y);
            return Math.Sqrt(S1);
        }

        public static bool IsVectorInSegment(Vector v, Segment sg)
        {
            B = ((v.X - sg.Begin.X) * (v.X - sg.End.X) <= 0) && ((v.Y - sg.Begin.Y) * (v.Y - sg.End.Y) < 0);
            if (((v.X == sg.Begin.X) || (v.X == sg.End.X)) && ((v.Y == sg.End.Y) || (v.Y == sg.Begin.Y)))
                return true;
            else
                return B;
        }
    }
}