using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial_Problem2
{
    class Client
    {
        public static void Main(string[] args)
        {
            IHumanSpeakA hA;
            IHumanSpeakB hB;
            Theodore t;

            hA = new Theodore();
            hB = new Theodore();

            //cast for assignement
            t = (Theodore)hA;

            //use class based reference
			t.Name="Fred";
			t.Speak("I like public implementations!");

			t = (Theodore)hB;
			
			//use class based reference
			t.Name="Fred";
			t.Speak("I like public implementations!");
			
			//use IHumanSpeakA interface based reference
			hA.Name = "Teddy";
			hA.Speak("I like C#!");

			//use IHumanSpeakB interface based reference
			hB.Name = "Teddy";
			hB.Speak("I like C#!");

			Console.ReadLine();

            Kirk k;

            hA = new Kirk();
            hB = new Kirk();

            //cast for assignement
            //use IHumanSpeakA interface based reference
            hA.Name = "Teddy";
            hA.Speak("I like C#!");
            
            //use IHumanSpeakB interface based reference
            hB.Name = "Teddy";
            hB.Speak("I like C#!");
            
            Console.ReadLine();
        }
    }
}
