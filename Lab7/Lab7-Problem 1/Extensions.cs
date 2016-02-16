using Lab7_Problem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem_1
{
    static class Extensions
    {
        public static double Volume(this Parallelepiped paral)
        {
            double w = Math.Abs(paral.SPoint.Coords[0] - paral.EPoint.Coords[0]);
            double l = Math.Abs(paral.SPoint.Coords[1] - paral.EPoint.Coords[1]);
            return w * l * paral.Height;
        }

        public static double Perimeter(this Rectangle rectangle)
        {
            return Math.Abs(rectangle.SPoint.Coords[0] - rectangle.EPoint.Coords[0]) *
                    Math.Abs(rectangle.SPoint.Coords[1] - rectangle.EPoint.Coords[1]);
        }
    }
}
