using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyElement
{
    public class Line: Point
    {
        Point sPoint;
        Point ePoint;

        // general purpose constructor
        public Line(Point sPoint, Point ePoint)
        {
            this.SPoint = sPoint;
            this.EPoint = ePoint;
        }

        // default constructor
        public Line()
            : this(new Point(), new Point())
        {

        }

        // copy constructor
        public Line(Line newLine)
            : this(newLine.SPoint, newLine.EPoint)
        {
        }

        // set and get properties for x
        public double X
        {
            get
            {
                return base.X;
            }
            set
            {
                base.X = X;   
            }
        }

        // set and get properties for y
        public double Y
        {
            get
            {
                return base.Y;
            }
            set
            {
                base.Y = value;
            }
        }

        // set and get properties for SPoint
        public Point SPoint
        {
            get
            {
                return new Point(this.sPoint);
            }
            set
            {
                if (value != null)
                {
                    this.sPoint = new Point(value.Weight, value.X, value.Y);
                }
                else
                {
                    this.sPoint = new Point();
                }
            }
        }

        // set and get properties for EPoint
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
                    this.ePoint = new Point(value.Weight, value.X, value.Y);
                }
                else
                {
                    this.ePoint = new Point();
                }
            }
        }

        // override ToString() method
        public override string ToString()
        {
            return string.Format("{0}; {1}", this.SPoint, this.EPoint);
        }

        // override CalWeight method
        public override double CalcWeight()
        {
            return Math.Sqrt((this.EPoint.Y - this.SPoint.Y) *
                                (this.EPoint.Y - this.SPoint.Y) +
                                (this.EPoint.X - this.SPoint.X) *
                                (this.EPoint.X - this.SPoint.X)) * (this.SPoint.Weight + this.EPoint.Weight) / 2;
        }
    }
}
