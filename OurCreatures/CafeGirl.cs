using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    /// <summary>
    /// Typical polish girl from poor family
    /// who needs to work in cafe to survive
    /// </summary>
    public class CafeGirl : Creature, IManipulated<PolishPan>
    {
        private PolishPan pan_;

        public int IQ { get; set; }

        public CafeGirl()
        {; }

        public CafeGirl(string name)
        {
            Name = name;
            
            Random rand = new Random();
            IQ = rand.Next(80, 110);
            if (IQ > 120)
                Resign();
        }

        public CafeGirl(string name, PolishPan pan)
        {
            Name = name;
            this.pan_ = pan;

            Random rand = new Random();
            IQ = rand.Next(80, 150);            
        }

        public string GetSalary()
        {
            // Every working mounth decreases IQ
            IQ--; 
            return pan_.IsSad ? "mało" : "spoko";
        }

        public void ButtleCry(string boyName)
        {
            Console.WriteLine("Kurwa, {0}, nic nie robisz w pracy! Już dzwonię do {1}", boyName, pan_.Name);
        }

        public void SetDriver(Creature driver)
        {
            driver_ = driver;
        }

        public void Resign()
        {
            Console.WriteLine("Mam dość tego!");
            pan_ = null;
        }
    }
}