using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Problem1
{
    class Program1
    {
        static void Main(string[] args)
        {
            // list of rectangles
            List<Rectangle> list = new List<Rectangle>();
            
            // add 4 rectangles in the list
            list.Add(new Rectangle(5, 3, new Point(new int[] { 1, 2 })));
            list.Add(new Rectangle(4, 4, new Point(new int[] { 2, 3 })));
            list.Add(new Rectangle(3, 5, new Point(new int[] { 3, 4 })));
            list.Add(new Rectangle(2, 6, new Point(new int[] { 4, 5 })));
        }

        
    }
}
