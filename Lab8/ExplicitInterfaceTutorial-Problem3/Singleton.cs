using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceTutorial_Problem3
{
    public class Singleton
    {
        private static Singleton singleton;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return Singleton.singleton;
        }
    }
}
