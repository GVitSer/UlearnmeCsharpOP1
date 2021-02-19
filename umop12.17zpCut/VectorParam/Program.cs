using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;

namespace GeometryTasks
{
    class Program
    {
        public static Vector
            v1 = new Vector { X = 3.2, Y = 8.5 },
            v2 = new Vector { X = 5.1, Y = 3.4 },
            VSum = new Vector { X = 0, Y = 0 };
        public static Segment
            sgm = new Segment
            {
                Begin = new Vector() { X = 8.1, Y = 11.36 },
                End = new Vector() { X = 15.74, Y = 19.42 }
            };
        public static void Main(string[] args)
        {
            Console.WriteLine("Длина вектора v1={0}", Geometry.GetLength(v1));            
            Geometry.Add(v1, v2);
            Console.WriteLine("Суммирующий вектор х={0} y={1}", Geometry.VSum.X, Geometry.VSum.Y);
            Console.WriteLine();
            Console.WriteLine("Длина сегмента sgm={0}", Geometry.GetLength(sgm));
            Console.WriteLine(Geometry.IsVectorInSegment(v1, sgm));
            Console.ReadKey();
        }
    }
}