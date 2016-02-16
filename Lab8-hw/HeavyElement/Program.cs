using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // create 2 objects of type Point
            Point pointA = new Point(1, 2, 5);
            Point pointB = new Point(2, 3, 4);

            // create 2 objects of type Line
            Line lineA = new Line(new Point(3, 1, 2), new Point(4, 3, 4));
            Line lineB = new Line(new Point(5, 2, 1), new Point(6, 4, 3));

            // create an array with 4 elements - the two points and the two lines
            HeavyElement[] hsElements = { pointA, pointB, lineA, lineB };

            // show the elements of the array
            for (int i = 0; i < hsElements.Length; i++)
            {
                Console.WriteLine(hsElements[i]);
            }

            Console.WriteLine();

            // mix elements of the array
            MixHeavyObjects(hsElements);

            // show the elements of the array
            for (int i = 0; i < hsElements.Length; i++)
            {
                Console.WriteLine(hsElements[i]);
            }
        }

        // method that mixes the elements of the array
        static void MixHeavyObjects(HeavyElement[] hs)
        {
            Random randomNumber = new Random();

            for (int i = 0; i < hs.Length; ++i)
            {
                int randNum = randomNumber.Next(0, hs.Length - 1);
                HeavyElement temp = hs[i];
                hs[i] = hs[randNum];
                hs[randNum] = temp;
            }
        }
    }
}
