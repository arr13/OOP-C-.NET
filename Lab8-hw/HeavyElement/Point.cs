using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyElement
{
    public class Point: HeavyElement
    {
        private double x;
        private double y;

        // general purpose constructor
        public Point(double weight, double x, double y)
            : base(weight)
        {
            this.X = x;
            this.Y = y;
        }

        // default constructor
        public Point()
            : this(0, 0, 0)
        {

        }

        // copy constructor
        public Point(Point newPoint)
            : this(newPoint.Weight, newPoint.X, newPoint.Y)
        {
        }

        // get and set properties of weight
        public double Weight
        {
            get
            {
                return base.Weight;
            }
            set
            {
                if (value.GetType() == base.Weight.GetType())
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 0;
                }
            }
        }

        // get and set properties of x
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value.GetType() == this.x.GetType())
                {
                    this.x = value;
                }
                else
                {
                    this.x = 0;
                }
            }
        }

        // get and set properties of y
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value.GetType() == this.y.GetType())
                {
                    this.y = value;
                }
                else
                {
                    this.y = 0;
                }
            }
        }

        // override ToString method
        public override string ToString()
        {
            return string.Format("({0},{1}); {2}", this.X, this.Y, this.Weight);
        }

        // override CalcWeight method
        public override double CalcWeight()
        {
            return this.Weight;
        }
    }
}
