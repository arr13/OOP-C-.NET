using System;

struct Vector : IComparable
{
    Point startPoint;
    Point endPoint;

    public override string ToString()
    {
        return this.startPoint + "; " + this.endPoint;
    }

    public Point this[string index]
    {
        get
        {
            switch (index)
            {
                case "start": return this.startPoint;
                case "end": return this.endPoint;
                default: Console.WriteLine("no such point"); break;
            }
            return new Point();
        }
    }

    public double SizeOf()
        {
            return Math.Sqrt((startPoint.X - endPoint.X) * (startPoint.X - endPoint.X) +
                               (startPoint.Y - endPoint.Y) * (startPoint.Y - endPoint.Y) +
                               (startPoint.Z - endPoint.Z) * (startPoint.Z - endPoint.Z));
        }

    private Vector GetSizeOf(Vector v1, Vector v2)
    {
        return v1.SizeOf() > v2.SizeOf() ? v1 : v2;
    }
}
