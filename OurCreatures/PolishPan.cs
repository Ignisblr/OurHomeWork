using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class PolishPan : Creature
    {
        bool isSad_;
        public bool IsSad { get { return !isSad_; } }

        public void SetGoodMood(string reason)
        {
            Console.WriteLine("Today our pan is happy because of {0}", reason);
            isSad_ = true;
        }

        public void SetBadMood(string reason)
        {
            Console.WriteLine("Today our pan is angry with {0}", reason);
            isSad_ = false;
        }
    }
}
