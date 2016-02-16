using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Problem2
{
    public class Rectangle
    {
        // array for 2 points that forms the rectangle
        private Point[] points;

        // general purpose constructor
        public Rectangle(Point[] points)
        {
            this.Points = points;
        }

        // default constructor
        public Rectangle()
            : this(new Point[2])
        {
        }

        // copy constructor
        public Rectangle(Rectangle newRectangle) :
            this(newRectangle.Points)
        {
        }

        // get and set properties for array points
        private Point[] Points
        {
            get
            {
                Point[] temp = new Point[points.Length];
                for (int i = 0; i < points.Length; ++i)
                {
                    temp[i] = points[i] != null ? new Point(points[i]) : new Point();
                }
                return temp;
            }
            set
            {
                points = new Point[value.Length];
                if (value != null && value.Length == 2)
                {
                    if (value[0].Coords[0] <= value[1].Coords[0] &&
                        value[0].Coords[1] >= value[1].Coords[1])
                    {
                        points[0] = value[0] != null ? new Point(value[0]) :
                                                        new Point();
                        points[1] = value[1] != null ? new Point(value[1]) :
                                                        new Point();
                    }
                }
                else
                {
                    points = new Point[0];
                }
                
            }
        }

        // override ToString method
        public override string ToString()
        {
         	 return Points[0] + "; " + Points[1];
        }

        // find perimeter of the rectangle
        public double Perimeter()
        {
            return 2 * (Math.Abs(Points[1].Coords[0] - Points[0].Coords[0]) +
                        Math.Abs(Points[1].Coords[1] - Points[0].Coords[1]));
        }

        // find the area of the circle around the rectangle
        public double Circle()
        {
            double R = Math.Sqrt(Math.Abs(Points[1].Coords[0] - Points[0].Coords[0]) *
                                 Math.Abs(Points[1].Coords[0] - Points[0].Coords[0]) +
                                 Math.Abs(Points[1].Coords[1] - Points[0].Coords[1]) *
                                 Math.Abs(Points[1].Coords[1] - Points[0].Coords[1]));
            return Math.PI * R * R;
        }
    }
}
