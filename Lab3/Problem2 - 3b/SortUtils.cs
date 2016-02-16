using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2___3b
{
    class SortUtils
    {
        // initialize the array
        public void InItArray(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("Insert a[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // print the array
        public void PrintArray(int[] a)
        {
            Console.Write("[");
            for (int i = 0; i < a.Length; ++i)
            {
                if (i == a.Length - 1)
                {
                    Console.Write(a[i]);
                }
                else
                {
                    Console.Write(a[i] + ",");
                }
            }
            Console.Write("]");
        }

        //bubble sort
        public void SortArray(int[] a)
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int sort = 0; sort < a.Length - 1; sort++)
                {
                    if (a[sort] > a[sort + 1])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                }
            }
        }

        public int[] Merge(int[] x, int[] y)
        {
            int[] a = x;
            int[] b = y;
            int abc = 0; //counter for a
            int abc2 = 0; //counter for b
            int i = 0; //counter for index of new array
            Boolean flagA = true; //if flag changed, array is exhaused
            Boolean flagB = true;
            int[] newarray = new int[a.Length + b.Length]; //so size is 7

            while (abc < a.Length && abc2 < b.Length)
            {
                if (a[abc] < b[abc2])
                {
                    newarray[i] = a[abc];
                    abc++;
                }
                else
                {
                    newarray[i] = b[abc2];
                    abc2++;
                }

                if (abc >= a.Length)
                {
                    flagA = true;
                    flagB = false;
                }

                else if (abc2 >= b.Length)
                {
                    flagA = false;
                    flagB = true;
                }
                i++;
            }

            if (flagA == false)
            {
                while (abc < a.Length)
                {
                    newarray[i] = a[abc];
                    abc++;
                    i++;
                }
            }
            else if (flagB == false)
            {
                while (abc2 < b.Length)
                {
                    newarray[i] = b[abc2];
                    abc2++;
                    i++;
                }
            }

            return newarray;
        }
    }
}
