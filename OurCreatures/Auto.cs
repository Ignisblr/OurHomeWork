using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class Auto : Machine, IManipulated<Human>
    {

        private Creature driver_ = null;
        public void SetDriver(Creature driver)
        {
            driver_ = driver as Human;
        }
    }
}
