using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Problem1
{
    public class Point
    {
        // declare array for coordinats of the point
        private int[] coords;

        // constructor for general purpose
        public Point(int[] coords)
        {
            Coords = coords;
        }

        // default constructor
        public Point()
            : this(new int[2])
        {
        }

        // copy constructor
        public Point(Point newPoint) : this(newPoint.Coords)
        {
        }

        // override ToString method
        public override string ToString()
        {
            return string.Format("({0}, {1})", Coords[0], Coords[1]);
        }

        // set and get properties for coords
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
