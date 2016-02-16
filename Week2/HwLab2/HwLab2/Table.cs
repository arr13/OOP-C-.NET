using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HwLab2
{
    public class Table
    {
        private int start; //declare field start of interval
        private int end; //declare field end of interval
        private int step; //declare field step
        private int interval; //declare interval
        private int counter; //declare counter 

        //constructor with parametrs
        public Table(int start, int end, int step)
        {
            //check if start is bigger than end
            //in this case replace their places
            if (start > end)
            {
                this.Start = end;
                this.End = start;
                this.Step = step;
                this.Interval = (this.End - this.Start) / this.Step;
                this.Counter = 0;
            }
            else
            {
                this.Start = start;
                this.End = end;
                this.Step = step;
                this.Interval = (this.End - this.Start) / this.Step;
                this.Counter = 0;
            }
        }

        public int End //property End
        {
            get
            {
                return end;
            }
            set
            {
                this.end = value;
            }
        }

        public int Start //property Start
        {
            get
            {
                return start;
            }
            set
            {
                this.start = value;
            }
        }

        public int Step //property Step
        {
            get
            {
                return step;
            }
            set
            {
                //validation if step is bigger or equal to 1
                if (value >= 1)
                {
                    step = value;
                }
            }
        }

        public int Interval //property Interval
        {
            get
            {
                return interval;
            }
            set
            {
                this.interval = value;
            }
        }

        public int Counter
        {
            get
            {
                return this.counter;
            }
            set
            {
                this.counter = value;
            }
        }

        //method that makes the table
        public void MakeTable()
        {            
            string x = "x";
            string fx = "f(x)";
            int i = this.Start;
            Console.WriteLine("-----------------");
            Console.WriteLine("|{0, 5} | {1,7}|", x, fx);
            Console.WriteLine("-----------------");

            for (i = this.Start; this.Counter < 20 && i <= this.End; i += interval)
            {
                Console.WriteLine("|{0, 5} | {1,7:F4}|", i, Math.Abs((i - 2) * (i - 2)) / (i * i + 1));
                Console.WriteLine("-----------------");
                this.Counter++;
            }

            if (this.Counter < this.End && this.Counter == 20)
            {
                Console.WriteLine("Press return to continue...");
                char returnButton = Convert.ToChar(Console.ReadLine());
                while (returnButton != (char)32)
                {
                    Console.WriteLine("Press return to continue...");
                    returnButton = Convert.ToChar(Console.ReadLine());
                }
                this.Start = i;
                this.Counter = 0;
            }
        }

        //method that prints the table
        public void PrintTable()
        {
            int counterMakeTable = this.End / 20;
            if (this.End % 2 == 0)
            {
                while (counterMakeTable > 0)
                {
                    this.MakeTable();
                    counterMakeTable--;
                }
            }
            else
            {
                while (counterMakeTable >= 0)
                {
                    this.MakeTable();
                    counterMakeTable--;
                }
            }           
        }
    }
}
