using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace umop12o10zCreatingExtensionMethods
{
    class Program
    {
        public static void Main()
        {
            var arg1 = "100500";
            Console.Write(arg1.ToInt() + "42".ToInt()); // 100542
            Console.ReadKey();
        }
    }
    public static class ToIntExtensions
    {
        public static int ToInt(this string arg)
        {
            return Convert.ToInt32(arg);
        }
    }

}
