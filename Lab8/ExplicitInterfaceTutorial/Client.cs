using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial
{
    public class Client
    {
        static void Main(string[] args)
        {
            IHuman h;
            Theodore t;

            h = new Theodore();

            //cast for assignement
            t = (Theodore)h;

            //use class based reference
            t.Name = "Fred";
            t.Speak("I like public implementations!");

            //use interface reference
            h.Name = "Teddy";
            h.Speak("I like C#!");

            Console.WriteLine("----------------------------------");

            Kirk k;

            h = new Kirk();

            //cast for assignement
            k = (Kirk)h;

            //use class based reference
            k.Name = "Fred";
            k.Speak("I like public implementations!");

            //use interface reference
            h.Name = "Teddy";
            h.Speak("I like C#!");
        }
    }
}
