using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    /// <summary>
    /// Shows instance of class Auto
    /// </summary>
    public class Auto : Machine, IManipulated<Human>
    {
        enum Type { Sport, Truck, Bus }

        //private Creature driver_ = null;

        /// <summary>
        /// Sets a driver to this creature
        /// Устанавливает водителя к этому созданию
        /// </summary>
        /// <param name="driver"></param>
        public void SetDriver(Creature driver)
        {
            if (driver == null)
            {
                throw(new NullReferenceException("Set some driver for this vehicle"));
            }
            
            //driver_ = driver as Human;
        }
    }
}
