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
        public static void Main(string[] args)
        {
            Console.WriteLine(Geometry.GetLength(v1));
            Geometry.Add(v1, v2);
            Console.WriteLine("Суммирующий вектор х={0} y={1}", Geometry.VSum.X, Geometry.VSum.Y);
            Console.ReadKey();
        }
    }
}