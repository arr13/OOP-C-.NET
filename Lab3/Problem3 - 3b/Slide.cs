using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3___3b
{
    class Slide<T>
    {
        private int start; // start index of current slide
        private T repeatingElement; // repeting element
        private int length; // length of slide

        // constructor with parametres
        public Slide(int start, T repeatingElement, int length)
        {
            this.Start = start;
            this.Length = length;
            this.RepeatingElement = repeatingElement;
        }

        // properties of all fields
        public int Start { get; set; }
        public int Length { get; set; }
        public T RepeatingElement { get; set; }

        //print current slide in a row of the table
        public void Print()
        {
            Console.WriteLine("|{0, 19}|{1,19}|{2,19}|", 
                        this.Start, this.Length, this.RepeatingElement);
        }
    }
}
