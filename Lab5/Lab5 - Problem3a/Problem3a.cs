using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___Problem3a
{
    class Problem3a
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            
            // declare list for letters
            List<char> letters = new List<char>();

            // fill letters with random numbers between 97 and 122
            for (int i = 0; i < 30; ++i)
            {
                letters.Add((char)randomNumber.Next(97, 123));
            }

            // sort list in ascending order
            Display(sortListAscending(letters));
            Console.WriteLine();

            // sort list in descending order
            Display(sortListDescending(letters));
            Console.WriteLine();

            // show only one of repeated numbers in
            // sorted list descendingly 
            Display(sortListAscending(letters).Distinct());
            Console.WriteLine();
        }

        // display results of requests
        static void Display(IEnumerable<char> sortLetters)
        {
            foreach (var letter in sortLetters)
            {
                Console.Write("{0}       ", letter);
            }
        }

        // sort list ascengingly
        static IEnumerable<char> sortListAscending(List<char> letters)
        {
            var sortLettersAscending =
                from letter in letters
                orderby letter
                select letter;
            return sortLettersAscending;
        }

        // sort list descending
        static IEnumerable<char> sortListDescending(List<char> letters)
        {
            var sortLettersDescending =
                from letter in letters
                orderby letter descending
                select letter;
            return sortLettersDescending;
        }
    }
}
