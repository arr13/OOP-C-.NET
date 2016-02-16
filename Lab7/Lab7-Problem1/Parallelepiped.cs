using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem1
{
    public class Parallelepiped: Rectangle
    {
        double height;

        public Parallelepiped(Rectangle rectangle, double height): base(rectangle)
        {
            this.Height = height;
        }

        public Parallelepiped(): this(new Rectangle(), 0.0)
        {
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    this.height = 0;
                }
            }


        }

        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle(base.SPoint, base.EPoint);
            }
            set
            {
                if (value != null)
                {
                    base.SPoint = value.SPoint;
                    base.EPoint = value.EPoint;
                }
                else
                {
                    base.EPoint = new Point();
                    base.SPoint = new Point();
                }
            }
        }

        public Parallelepiped(Parallelepiped newParallelepiped): base(newParallelepiped.Rectangle.SPoint, newParallelepiped.Rectangle.EPoint)
        {
            this.height = newParallelepiped.Height;
        }

        public override string ToString()
        {
            return base.SPoint + "; " + base.EPoint + "; " + this.Height;
        }

        public double Area()
        {
            double a = Math.Abs(this.EPoint.Coords[0] - this.SPoint.Coords[0]);
            double b = Math.Abs(this.EPoint.Coords[1] - this.SPoint.Coords[1]);
            return 2 * a * b + 2 * a * this.Height + 2 * b * this.Height;
        }
    }
}
