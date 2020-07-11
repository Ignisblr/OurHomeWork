using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    /// <summary>
    /// Sets a driver to some creature
    /// </summary>
    /// <typeparam name="T">This parameter means that creature has a driver and this creature is manipulated already</typeparam>
    public interface IManipulated<out T> where T: Creature
    {
        void SetDriver(Creature driver);
    }
}
