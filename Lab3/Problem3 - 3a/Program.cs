using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3___3a
{
    class Program
    {
        static void Main(string[] args)
        {
            double accuracy; // declare a variable for accuracy
            double x; // declare a variable for argument of cos

            // inicialization of x
            Console.Write("Insert x: ");
            x = double.Parse(Console.ReadLine());

            //inicialization of accuracy
            Console.Write("Insert accuracy: ");
            accuracy = double.Parse(Console.ReadLine()); // inicialization of accuracy
            
            //insert accuracy while it is between 0 and 1
            while (accuracy <= 0 || accuracy >= 1)
            {
                Console.WriteLine("Error! accuracy must be between 0 and 1");
                Console.Write("Please insert accuracy: ");
                accuracy = double.Parse(Console.ReadLine());
            }

            Console.WriteLine(CalculateCos(x, accuracy));
            Console.WriteLine(Math.Cos(3));
        }

        static double CalculateCos(double x, double accuracy)
        {
            double result = 1;
            int count = 2;
            int fact = 1;
            int countPlusOrMinus = 0;

            while (Math.Abs(Math.Cos(x) - result) > accuracy)
            {
                if (countPlusOrMinus % 2 == 0)
                {
                    result -= Math.Pow(x, count) / (double)factoriel(ref fact, count);
                }
                else
                {
                    result += Math.Pow(x, count) / (double)factoriel(ref fact, count);
                }
                count += 2;
                countPlusOrMinus++;
            }

            return result;
        }

        private static double factoriel(int fact, int count)
        {
            throw new NotImplementedException();
        }

        static int factoriel(ref int factoriel, int count)
        {
            if (count == 2)
            {
                factoriel = 2;
                return factoriel;
            }
            else
            {
                factoriel *= (count * (count - 1));
                return factoriel;
            }
        }
    }
}
