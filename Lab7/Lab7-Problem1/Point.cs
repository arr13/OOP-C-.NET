using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem1
{
    public class Point
    {
        private int[] coords;
        
        public Point(int[] coords)
        {
            Coords = coords;
        }

        public Point()
            : this(new int[2])
        {
        }

        public Point(Point newPoint): this(newPoint.Coords)
        {
        }

        public override string ToString()
        {
            return "(" + Coords[0] + ", " +  Coords[1] + ")";
        }

        public int[] Coords
        {
            get
            {
                return new int[] { coords[0], coords[1] };
            }
            set
            {
                if (value != null && value.Length == 2)
                {
                    coords = new int[2];
                    for (int i = 0; i < value.Length; ++i)
                    {
                        this.coords[i] = value[i];
                    }

                    //coords = new int[] { value[0], value[1] };
                }
                else
                {
                    coords = new int[0];
                }
            }
        }
    }
}
