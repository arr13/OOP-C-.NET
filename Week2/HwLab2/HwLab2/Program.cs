using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 39;
            int step = 38;
            Table table = new Table(start, end, step);
            table.PrintTable();
        }
    }
}
