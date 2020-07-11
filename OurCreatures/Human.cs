using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class Human : Creature
    {
        int Age { get; set; }
        string Name { get; set; }

        double Weight { get; set; }
        enum Race { European, Asian, Negro, Indian }
    }
}
