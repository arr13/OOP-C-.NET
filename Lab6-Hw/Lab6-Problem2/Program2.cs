using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Problem2
{
    class Program2
    {
        static void Main(string[] args)
        {
            // declare and initialize two int arrays with coordinates of 2 points
            int[] coords1 = { 2, 5 };
            int[] coords2 = { 4, 3 };

            // declare and initialize 2 points
            Point point1 = new Point(coords1);
            Point point2 = new Point(coords2);

            // declare and initialize an array with the 2 points
            Point[] points = { point1, point2 };

            // declare and initialize a rectangle
            Rectangle rectangle = new Rectangle(points);
            
            // show rectangle coordinates
            Console.WriteLine(rectangle);

            // show rectangle`s perimeter
            Console.WriteLine(rectangle.Perimeter());

            // show area of the circle around the rectangle
            Console.WriteLine(rectangle.Circle());
        }
    }
}

