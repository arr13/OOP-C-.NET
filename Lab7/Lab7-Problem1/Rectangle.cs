using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem1
{
    public class Rectangle: Point
    {
        Point ePoint;

        public Rectangle(Point sPoint, Point ePoint): base(sPoint)
        {
            this.EPoint = ePoint;
        }

        public Rectangle()
            : this(new Point(new int[2]), new Point(new int[2]))
        {

        }

        public Point EPoint 
        {
            get
            {
                return new Point(ePoint);
            }
            set
            {
                if (value != null)
                {
                    this.ePoint = new Point(value);
                }
                else
                {
                    this.ePoint = new Point();
                }                
            }
        }

        public Point SPoint
        {
            get
            {
                return new Point(base.Coords);
            }
            set
            {
                if (value != null)
                {
                    base.Coords = value.Coords;
                }
                else
                {
                    base.Coords = new int[2];
                }
            }
        }

        public Rectangle(Rectangle newRectangle): base(newRectangle.SPoint) 
        {
            this.EPoint = new Point(newRectangle.EPoint);
        }

        public override string ToString()
        {
            return this.SPoint + "; " + this.EPoint;
        }

        public double Area()
        {
            return Math.Abs(this.EPoint.Coords[0] - this.SPoint.Coords[0]) * 
                    Math.Abs(this.EPoint.Coords[1] - this.SPoint.Coords[1]);
        }
    }
}
