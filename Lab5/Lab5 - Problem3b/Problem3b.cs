using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___Problem3b
{
    class Problem3b
    {
        static void Main(string[] args)
        {
            // declare and initialize number
            int number = int.Parse(Console.ReadLine());

            // declare and initialize string for all numbers 
            // between 0 and number
            string allNumbersString = "";

            // fill allNumberString with all numbers between 
            // 1 and number
            while (number != 0)
            {
                allNumbersString += number;
                number--;
            }

            // allNumbersString to char array
            char[] allNumbersArr = allNumbersString.ToCharArray();

            // request that picks only '1'
            var findOnes =
                from num in allNumbersArr
                where num == '1'
                select num;

            // show the number of '1'
            Console.WriteLine(findOnes.Count<char>());
        }
    }
}
