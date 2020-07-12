using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class Animal : Creature
    {
        public int Age { get; set; }
        public bool Sick { get; set; }

        public enum Classification { Fish, Bird, Mammal }

        public string GetClass(Classification classification)
        {
            return classification.ToString();
        }

        public double GetSpeed()
        {
            Speed = Sick == true ? base.Speed * 0.6 : base.Speed;
            return Speed;
        }
    }
}
