using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryTasks;


namespace GeometryPainting
{
    public static class SegmentExtensions
    {
        private static Dictionary<Segment, Color> cvet = new Dictionary<Segment, Color>();

        public static void SetColor(this Segment s, Color color)
        {
            if (cvet.ContainsKey(s))
                cvet[s] = color;
            else
                cvet.Add(s, color);
        }

        public static Color GetColor(this Segment s)
        {
            if (cvet.ContainsKey(s))
                return cvet[s];
            else
                return Color.Black;
        }
    }
}
