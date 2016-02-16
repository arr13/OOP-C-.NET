using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Problem1
{
    class Rectangle
    {
        // declare length, width, point and array(for indexer)
        private double length;
        private double width;
        private Point point;
        private static char[] codes = { 'x', 'y', 'w', 'h' };

        // general purposer constructor
        public Rectangle(double length, double width, Point point)
        {
            this.Length = length;
            this.Width = width;
            this.Point = point;
        }

        // default constructor
        public Rectangle()
            : this(0, 0, new Point(new int[] { 0, 0 }))
        {
        }

        // copy constructor
        public Rectangle(Rectangle newRectangle)
            : this(newRectangle.Length, newRectangle.Width, newRectangle.Point)
        {
        }

        // set and get properties for length
        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value > 0)
                {
                    this.length = value;
                }
            }
        }

        // set and get properties for width
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
            }
        }

        // set and get properties for point
        public Point Point
        {
            get
            {
                Point temp = this.point != null ? new Point(this.point) :
                                                  new Point();
                return temp;
            }
            set
            {
                if (value != null)
                {
                    this.point = new Point(value);
                }
                else
                {
                    this.point = new Point();
                }
            }
        }

        // indexer
        public double this[char index]
        {
            get
            {
                switch (index)
                {
                    case 'x': return this.Point.Coords[0];
                    case 'y': return this.Point.Coords[1];
                    case 'w': return this.Width;
                    case 'h': return this.Length;
                    default: return -1;
                }
            }
        }

        // override ToString method
        public override string ToString()
        {
            return String.Format("length: {0}\nwidth: {1}\npoint: {2}\narea: {3:f2}\ndiagonal: {4:f2}",
                this.Length, this.Width, this.Point, Area(this), Diagonal(this));
        }

        // find area 
        public static double Area(Rectangle r)
        {
            double width = r.Width + Math.Abs(r.Point.Coords[0]);
            double length = r.Length + Math.Abs(r.Point.Coords[1]);
            return width * length;
        }

        // find diagonal 
        public static double Diagonal(Rectangle r)
        {
            double width = r.Width + Math.Abs(r.Point.Coords[0]);
            double length = r.Length + Math.Abs(r.Point.Coords[1]);
            return Math.Sqrt(width * width + length * length);
        }

        public delegate double CompareBy(Rectangle r);

        public static IEnumerable<Rectangle> SortBy(List<Rectangle> rect, CompareBy del)
        {
            return rect.OrderBy(x => del(x));
        }
    }
}
