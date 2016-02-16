using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9_Problem1;

namespace Lab9_Problem1_Application
{
    public static class Extensions
    {
        public static List<int> Filter(
            this Vector vector, 
            Predicate<int> test)
        {
            List<int> list = new List<int>();

            foreach (int i in vector.P)
            {
                if (test(i) == true)
                    list.Add(i);
            }

            return list;
        }
    
        public static Vector Map(
            this Vector vector,
            Func<int, int> map)
        {
            List<int> list = new List<int>();

            foreach (int item in vector.P)
            {
                list.Add(map(item));
            }

            return new Vector(0, list.ToArray());
        } 
    }
}
