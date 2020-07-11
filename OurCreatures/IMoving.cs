using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public interface IMoving
    {
        double Speed { get; set; }
        string MovingType { get; set; }
        void Move();
    }
}
