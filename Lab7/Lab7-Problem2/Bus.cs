using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem2
{
    public class Bus: MotorVehicle
    {
        private int numPassengers;
        private bool airCond;

        public Bus(double tankVolume, int numPassengers, bool airCond)
            : base(tankVolume)
        {
            this.NumPassengers = numPassengers;
            this.AirCond = airCond;
        }

        public Bus()
            : this(0, 0, false)
        {
        }

        public Bus(Bus newBus)
            : this(newBus.TankVolume, 
                    newBus.NumPassengers, newBus.AirCond)
        {

        }

        public override string ToString()
        {
            return this.REG_NUM + "; " + this.TankVolume + "; " +
                   this.NumPassengers + "; " + this.AirCond;
        }
        
        public int NumPassengers
        {
            get
            {
                return this.numPassengers;
            }
            set
            {
                if (value >= 0)
                {
                    this.numPassengers = value;
                }
                else
                {
                    this.numPassengers = 0;
                }
            }
        }

        public bool AirCond
        {
            get
            {
                return this.airCond;
            }
            set
            {
                if (value == true || value == false)
                {
                    this.airCond = value;
                }
                else
                {
                    this.airCond = false;
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null && this.GetType() != obj.GetType())
            {
                return false;
            }

            Bus b = (Bus)obj;

            return (this.REG_NUM.Equals(b.REG_NUM) &&
                    this.TankVolume == b.TankVolume &&
                    this.NumPassengers == b.NumPassengers &&
                    this.AirCond == b.AirCond);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        static public bool operator ==(Bus b1, Bus b2)
        {
            if ((object)b1 == null) return false;

            return b1.Equals(b2);
        }

        static public bool operator !=(Bus b1, Bus b2)
        {
            if ((object)b1 == null) return false;

            return !b1.Equals(b2);
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
            Console.WriteLine("Bus: " + this);
        }
    }
}
