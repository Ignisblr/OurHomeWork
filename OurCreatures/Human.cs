using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class Human : Animal
    {
        const Animal.Classification classification = Classification.Mammal;
        double Weight { get; set; }
        enum Race { European, Asian, Negro, Indian }
    }
}
