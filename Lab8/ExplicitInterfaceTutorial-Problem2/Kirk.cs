using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial_Problem2
{
    public class Kirk: IHumanSpeakA, IHumanSpeakB
    {
        private string name;

        void IHumanSpeakA.Speak(string Message)
        {
            Console.WriteLine(Message + "Speaks A");
        }

        void IHumanSpeakB.Speak(string Message)
        {
            Console.WriteLine(Message + "Speaks B");
        }

        string IHuman.Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
