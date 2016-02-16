using Lab7_Problem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem_1
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Point point = new Point(new int[] { 2, 5 });
            Rectangle rectangle = new Rectangle(point, new Point(new int[] { 4, 3 }));

            Console.WriteLine(rectangle);

            Parallelepiped paral = new Parallelepiped(rectangle, 3);
            Console.WriteLine(paral);

            Console.WriteLine(paral.Volume());
            Console.WriteLine(rectangle.Perimeter());
        }
    }
}
