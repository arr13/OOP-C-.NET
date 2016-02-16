using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___Problem4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            // declare an array for random numbers
            int[] array = new int[100];
            Random randomNumber = new Random();

            // initialize array with random numbers between 20 and 50
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = randomNumber.Next(20, 51);
            }

            // show grouped array
            Group(array);
        }

        // group array by module 8
        static void Group(int[] array)
        {
            var group =
                from number in array
                let remainder = number % 8
                orderby remainder
                group number by remainder into g
                select new { Remainder = g.Key, Numbers = g };

            foreach (var element in group)
            {
                Console.WriteLine("Numbers with remainder {0}:", element.Remainder);
                foreach (var number in element.Numbers)
                {
                    Console.Write(" {0}", number);
                }
                Console.WriteLine();
            }
        }
    }
}
