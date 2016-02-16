using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            // declare and initialize sentence
            string sentence = Console.ReadLine();

            // all letters to be low
            sentence = sentence.ToLower();
            string[] words = sentence.Split();

            // show nonDuplicateWords
            Display(NonDuplcateWords(words).Distinct());
        }


        // sort non word in ascending order
        static IEnumerable<string> NonDuplcateWords(string[] words)
        {
            var nonDuplicateWords =
                from word in words
                orderby word
                select word;

            return nonDuplicateWords;
        }

        // display result from requests
        static void Display (IEnumerable<string> nonDuplicateWords)
        {
            foreach (var word in nonDuplicateWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
