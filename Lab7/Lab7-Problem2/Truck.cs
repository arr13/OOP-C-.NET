using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem2
{
    public class Truck : MotorVehicle
    {
        private int maxLoad;

        public Truck(double tankVolume, int maxLoad)
            : base(tankVolume)
        {
            this.MaxLoad = maxLoad;
        }

        public Truck()
            : this(0, 0)
        {

        }

        public Truck(Truck newTruck)
            : this(newTruck.TankVolume, newTruck.MaxLoad)
        {

        }

        public override string ToString()
        {
            return this.REG_NUM + "; " + this.TankVolume + "; " +
                   this.MaxLoad;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            Truck t = (Truck)obj;

            return this.REG_NUM.Equals(t.REG_NUM) &&
                    this.TankVolume == t.TankVolume &&
                    this.MaxLoad == t.MaxLoad;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        static public bool operator ==(Truck t1, Truck t2)
        {
            if ((object)t1 == null) return false;

            return t1.Equals(t2);
        }

        static public bool operator !=(Truck t1, Truck t2)
        {
            if ((object)t1 == null) return false;

            return t1.Equals(t2);
        }

        public int MaxLoad
        {
            get
            {
                return this.maxLoad;
            }
            set
            {
                if (value >= 0)
                {
                    this.maxLoad = value;
                }
                else
                {
                    this.maxLoad = 0;
                }
            }
        }

        public double TankVolume
        {
            get
            {
                return base.TankVolume;
            }
            set
            {
                if (value >= 0)
                {
                    base.TankVolume = value;
                }
                else
                {
                    base.TankVolume = 0;
                }
            }
        }

        public override void GiveInfo()
        {
            Console.WriteLine("Truck: " + this);
        }

    }
}
