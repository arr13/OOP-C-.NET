using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4___Problem2
{
    class Problem3
    {
        static void Main(string[] args)
        {
            int numberToInt; // the number that will be coded
            string number; // the same number in string

            Console.Write("Enter numbre: ");
            number = Console.ReadLine();
            numberToInt = int.Parse(number); // initialization of number

            // check if number has 3 ditis; insert while it is true
            while (numberToInt < 100 || numberToInt > 999)
            {
                Console.WriteLine("Error!");
                Console.Write("Enter numbre: ");
                numberToInt = int.Parse(Console.ReadLine());
            }
            number = Convert.ToString(numberToInt);

            // call function that codes the number
            Code(number);
        }

        // code the number
        static void Code(string number)
        {
            // for every digit of number from left ot right call function that codes the current digit
            for (int i = 0; i < number.Length; i++)
            {
                SwitchCode(number[number.Length - i - 1]);
            }  
        }

        // code the current digit
        static void SwitchCode(int digit)
        {
            switch (digit)
            {
                case '1': Console.Write(": : : | | "); break;
                case '2': Console.Write(": : | : | "); break;
                case '3': Console.Write(": : | | : "); break;
                case '4': Console.Write(": | : : | "); break;
                case '5': Console.Write(": | : | : "); break;
                case '6': Console.Write(": | | : : "); break;
                case '7': Console.Write("| : : : | "); break;
                case '8': Console.Write("| : : | : "); break;
                case '9': Console.Write("| : | : : "); break;
                case '0': Console.Write("| | : : : "); break;
            }
        }
    }
}
