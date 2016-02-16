using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[4];

            vehicles[0] = new MotorVehicle(52.30);
            vehicles[1] = new PrivateCar(67.91, 4);
            vehicles[2] = new Bus(74.11, 54, true);
            vehicles[3] = new Truck(89.99, 97);

            for (int i = 0; i < vehicles.Length; ++i)
            {
                vehicles[i].GiveInfo();
            }

            Console.WriteLine();
        }
    }
}
