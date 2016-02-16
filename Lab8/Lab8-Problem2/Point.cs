using System;

struct Point : IComparable
{
    private double x;
    private double y;
    private double z;

    public double X
    {
        get
        {
            return x;
        }
        set
        {
            if (value.GetType() == x.GetType())
            {
                x = value;
            }
            else
            {
                x = 0;
            }
        }
    }

    public double Y
    {
        get
        {
            return y;
        }
        set
        {
            if (value.GetType() == y.GetType())
            {
                y = value;
            }
            else
            {
                y = 0;
            }
        }
    }

    public double Z
    {
        get
        {
            return z;
        }
        set
        {
            if (value.GetType() == z.GetType())
            {
                z = value;
            }
            else
            {
                z = 0;
            }
        }
    }

    public double SizeOf()
    {
        return Math.Abs(X + Y + Z);
    }

    public override string ToString()
    {
        return String.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
    }

    public delegate bool GreaterOf(IComparable obj1, IComparable obj2);

    private Point GetSizeOf(Point p1, Point p2)
    {
        return p1.SizeOf() > p2.SizeOf() ? p1 : p2;
    }
}