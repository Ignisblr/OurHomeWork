using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class PolishPan : Creature
    {
        bool moodState_;
        public bool IsSad { get { return !moodState_; } }

        public void SetGoodMood(string reason)
        {
            Console.WriteLine("Today our pan is happy because of {0}", 0);
            moodState_ = true;
        }

        public void SetBadMood(string reason)
        {
            Console.WriteLine("Today our pan is angry with {0}", 0);
            moodState_ = false;
        }
    }
}
