using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyElement
{
    public abstract class HeavyElement
    {
        private double weight;

        // general purpose constructor
        public HeavyElement(double weight)
        {
            this.Weight = weight;
        }

        // default constructor
        public HeavyElement() : this(0)
        { 
        }

        // get and set properties of weight
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value >= 0)
                {
                    this.weight = value;
                }
                else
                {
                    this.weight = 0;
                }
            }
        }

        // declaration of abstract method CalcWeight
        public abstract double CalcWeight();
    }
}
