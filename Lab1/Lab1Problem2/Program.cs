using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Problem2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //declaration of variables
            int num1;
            int num2;
            int num3;

            //inizialization of variables
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter third number: ");
            num3 = int.Parse(Console.ReadLine());

            //find median of first, second and third number
            FindMedian(num1, num2, num3);
        }

        static void FindMedian(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 <= num3)
            {
                Console.WriteLine("The median is: " + num1);
            }
            else if (num2 >= num1 && num2 <= num3)
            {
                Console.WriteLine("The median is: " + num2);
            }
            else if (num3 >= num1 && num3 <= num2)
            {
                Console.WriteLine("The median is: " + num3);
            }
        }
    }
}
