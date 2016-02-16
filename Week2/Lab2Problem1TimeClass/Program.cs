using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Problem1TimeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            byte hour = 5;
            byte minute = 25;
            byte second = 37;
            Time time = new Time(hour, minute, second);

            time.ShowTome();           
        }
    }
}
