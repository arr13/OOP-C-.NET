using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.GetInstance() == Singleton.GetInstance());
        }
    }
}
