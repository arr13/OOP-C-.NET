using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3___3b
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr = { 1, 1, 1, 1, 1, 2, 5, 5, 7, 9, 9, 10, 10 }; // declarate and initialize the arr
            bool areThereSlides = false; // checks if there are slides in arr
            
            // prints the first 3 rows of the table 
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("|       start       |      length       | repeating element |");
            Console.WriteLine("-------------------------------------------------------------");

            // finds slides and prints them
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    areThereSlides = true;
                    Slide<int> slide = new Slide<int>(i, arr[i], 1);
                    int p = i;
                    while (p < arr.Length - 1 && arr[p] == arr[p + 1])
                    {
                        slide.Length++;
                        p++;
                    }
                    slide.Print();
                    i = p;
                }
            }

            // if there are no slides prints that there aren`t no slides
            if (areThereSlides == false)
            {
                Console.WriteLine();
                Console.WriteLine("There are no slides");
            }
        }
    }
}
