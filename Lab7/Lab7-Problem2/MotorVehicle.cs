using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Problem2
{
    public class MotorVehicle: Vehicle
    {
        private double tankVolume;
        protected readonly string REG_NUM;
        private static long counter;

        public MotorVehicle(double tankVolume)
        {
            this.REG_NUM = string.Format("CA{0:D4}AB", counter++);
            this.TankVolume = tankVolume;
        }

        public MotorVehicle()
            : this(0)
        {

        }

        public MotorVehicle(MotorVehicle newMotorVehicle)
            : this(newMotorVehicle.TankVolume)
        {

        }

        public override string ToString()
        {
            return String.Format(this.REG_NUM + "; " + this.TankVolume);
        }

        public double TankVolume
        {
            get
            {
                return this.tankVolume;
            }
            set
            {
                if (value >= 0)
                {
                    this.tankVolume = value;
                }
                else
                {
                    this.tankVolume = 0;
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            MotorVehicle m = (MotorVehicle)obj;

            return this.REG_NUM.Equals(m.REG_NUM) &&
                    this.TankVolume == m.TankVolume;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        static public bool operator ==(MotorVehicle m1, MotorVehicle m2)
        {
            if ((object)m1 == null) return false;

            return m1.Equals(m2);
        }

        static public bool operator !=(Bus b1, Bus b2)
        {
            if ((object)b2 == null) return false;

            return !b2.Equals(b1);
        }

        public override void GiveInfo()
        {
            Console.WriteLine("Motor vehicle: " + this);
        }

        public bool Greater(MotorVehicle v)
        {
            if (this.TankVolume >= v.TankVolume)
            {
                return true;
            }
            return false;
        }
 }
}
