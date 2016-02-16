using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Problem3
{
    public class ListBoxTest
    {
        // declare an array for strings in ListBox and a counter for their number
        private string[] myStrings;
        private int ctr;
        private string[] myStrings1;
        private string[] myStrings2;

        // general purpose constructor
        public ListBoxTest(string[] myStrings, int ctr)
        {
            this.MyStrings = myStrings;
            this.Ctr = ctr;
        }

        // default constructor
        public ListBoxTest() : this(new string[]{}, 0)
        {
        }

        // copy constructor
        public ListBoxTest(ListBoxTest newListBoxTest)
            : this(newListBoxTest.MyStrings, newListBoxTest.Ctr)
        {
        }

        public ListBoxTest(string[] myStrings1, string[] myStrings2)
        {
            // TODO: Complete member initialization
            this.myStrings1 = myStrings1;
            this.myStrings2 = myStrings2;
        }

        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < this.Ctr; ++i)
            {
                temp += this.MyStrings[i];
            }

            return this.Ctr + "\n" + temp;
        }

        // get and set properties of myString
        public string[] MyStrings
        {
            get
            {
                string[] temp = new string[myStrings.Length];
                for (int i = 0; i < temp.Length; ++i)
                {
                    temp[i] = this.myStrings[i] != null ? this.myStrings[i] : "";
                }
                return temp;
            }
            set
            {
                myStrings = new string[value.Length];
                for (int i = 0; i < myStrings.Length; ++i)
                {
                    myStrings[i] = value[i] != null ? value[i] : "";
                }
            }
        }

        // get and set properties of ctr
        public int Ctr
        {
            get
            {
                return this.ctr;
            }
            set
            {
                if (value >= 0)
                {
                    this.ctr = value;
                }
                else
                {
                    this.ctr = 0;
                }
            }
        }
    }
}
