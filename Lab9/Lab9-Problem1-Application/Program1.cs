using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9_Problem1;

namespace Lab9_Problem1_Application
{
    public class Program1
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int[] p = new int[7];
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = random.Next(0, 8);
            }

            Vector vector = new Vector(2, p);
            Console.WriteLine(vector);
            Console.WriteLine(((ISelectable)vector)[4]);

            List<int> list = vector.Filter(x => x >= 3);
            Console.WriteLine(string.Join(", ", list));

            Vector vector1 = vector.Map(x => x * x);
            Console.WriteLine(vector1);

            int[] array = { 0, 1, 2, 3, 4, 5, 6 };

            var filterElementsBiggerThanIndexes =
                array.Where(x => vector.P[x] > x);

            foreach (var item in filterElementsBiggerThanIndexes)
            {
                Console.Write(vector.P[item] + " ");
            }

            Console.WriteLine();

            double average = 0;
            for (int i = 0; i < vector.P.Length; i++)
			{
			 average += vector.P[i];
			}
            average /= vector.P.Length;

            var filterBiggerThanAverage = vector.P.Where(x => x >= average);

            Console.WriteLine(String.Join(" ", filterBiggerThanAverage));
        }
    }
}
