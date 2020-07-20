﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurCreatures
{
    public class Creature: IMoving
    {
        protected Creature driver_ = null;
        bool manipulated_ = false;
        double movingSpeed_ = 0;
        string movingType = null;

        public Creature GetDriver()
        {
            return driver_;
        }

        public bool Manipulated
        {
            get { return manipulated_; }
            protected set { manipulated_ = value; }

        }

        public string Name { get; set; }

        public double Speed
        {
            get { return movingSpeed_; }
            set { movingSpeed_ = value; }
        }

        public string MovingType
        {
            get { return movingType; }
            set { movingType = value; }
        }
        public void Move()
        {
            Console.WriteLine(String.Format("This {0} is moving by {1} with speed of {2} and driven by {3}", this.Name, 
                MovingType, Speed, GetDriver() == null ? "nobody" : GetDriver().ToString()));
        }
    }
}
