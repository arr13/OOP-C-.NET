using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem2
{
    public class PrivateCar: MotorVehicle
    {
        private int numSeats;

        public PrivateCar(double tankVolume, int numSeats)
            : base(tankVolume)
        {
            this.NumSeats = numSeats;
        }

        public PrivateCar()
            : this(0, 0)
        {
        }

        public PrivateCar(PrivateCar newPrivateCar)
            : this(newPrivateCar.TankVolume, newPrivateCar.NumSeats)
        {

        }

        public override string ToString()
        {
            return this.REG_NUM + "; " + this.TankVolume + "; " + this.NumSeats;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            PrivateCar p = (PrivateCar)obj;

            return this.REG_NUM.Equals(p.REG_NUM) &&
                    this.TankVolume == p.TankVolume &&
                    this.NumSeats == p.NumSeats;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(PrivateCar p1, PrivateCar p2)
        {
            if ((object)p1 == null) return false;

            return p1.Equals(p2);
        }

        public static bool operator !=(PrivateCar p1, PrivateCar p2)
        {
            if ((object)p1 == null) return false;

            return !p1.Equals(p2);
        }

        public int NumSeats
        {
            get
            {
                return this.numSeats;
            }
            set
            {
                if (value >= 2)
                {
                    this.numSeats = value;
                }
                else
                {
                    this.numSeats = 0;
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
            Console.WriteLine("Private Car: " + this);
        }
    }
}
