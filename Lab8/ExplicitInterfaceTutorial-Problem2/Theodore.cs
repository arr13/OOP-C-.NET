﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial_Problem2
{
    public class Theodore: IHumanSpeakA, IHumanSpeakB
    {
        private string name;

        public void Speak(string Message)
        {
            Console.WriteLine("Hi my name is {0}.\n" + Message, name);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null)
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Name cannot be set to null!");
                }
            }
        }
    }
}
