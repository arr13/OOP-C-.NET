using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Problem3
{
    public class Program3
    {
        static void Main(string[] args)
        {
            // declare and initialize new array of strings
            string[] myStrings = { "a", "b", "c" };

            // the array length
            int myStringsLength = myStrings.Length;

            // declare and initialize new ListBoxTest object
            ListBoxTest list = new ListBoxTest(myStrings, myStringsLength);

            // show list`s components
            Console.WriteLine(list);
        }
    }
}
