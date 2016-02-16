using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial_Problem2
{
    //declare interface
    public interface IHuman
    {
        string Name { get; set; }
    }

    interface IHumanSpeakA : IHuman
    {
        void Speak(string Message);
    }

    interface IHumanSpeakB : IHuman
    {
        void Speak(string Message);
    }
}
