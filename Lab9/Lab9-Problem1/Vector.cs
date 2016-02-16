using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Problem1
{
    public class Vector: ISelectable
    {
        private int[] p;
        // value of the first index of a Vector element 
        private int i1;

        public Vector(): this(0, new int[0])
        {
            // default constructor
        }

        public Vector(int firstIndex, int[] array)
        {
            this.P = array;
            this.I1 = firstIndex;
        }
        
        public Vector(Vector v): this(v.I1, v.P)
        {
            //copy constuctor
        }

        public int[] P
        {
            get
            {
                return p;
            }
            set
            {
                if (value != null)
                {
                    p = value;
                }
                else
                {
                    throw new Exception("The array cannot be null");
                }
            }
        }

        public int I1
        {
            get
            {
                return i1;
            }
            set
            {
                if (value < int.MaxValue && value > int.MinValue)
                {
                    i1 = value;
                }
                else
                {
                    throw new Exception("Error in index!");
                }
            }
        }

        public override string ToString()
        {
            return String.Format(string.Join(", ", P));
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Vector temp = obj as Vector;

            if (temp == null || P.Length != temp.P.Length)
                return false;

            for (int i = 0; i < P.Length; i++)
            {
                if (this.P[i] != temp.P[i])
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            if ((object)v1 == null || 
                v1.GetType() != v2.GetType()) 
                return false;

            return v1.Equals(v2);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            if ((object)v1 == null ||
                v1.GetType() != v2.GetType())
                return true;

            return !v1.Equals(v2);
        }

        public static implicit operator int[](Vector vector)
        {
            return vector.P;
        }

        public static explicit operator Vector(int[] p)
        {
            Vector vector = new Vector(0, p);
            return vector;
        }

        int ISelectable.this[int index]
        {
            get
            {
                if (index >= I1 && index < I1 + P.Length)
                {
                    return P[index - I1];
                }
                else
                {
                    throw new Exception("No such index!");
                }
            }
            set
            {
                if (index >= I1 && index < I1 + P.Length)
                {
                    P[index - I1] = value;
                }
                else
                {
                    throw new Exception("No such index!");
                }
            }
        }
    }
}
