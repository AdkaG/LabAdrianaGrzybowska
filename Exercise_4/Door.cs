using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Door
    {
        double doorWidth;
        double doorHeight;

        public double DoorWidth
        {
            get
            {
                return doorWidth;
            }

            set
            {
                if (value >= 0.40)
                    doorWidth = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double DoorHeight
        {
            get
            {
                return doorHeight;
            }

            set
            {
                if (value >= 1.80)
                    doorHeight = value;
                else
                    throw new Exception("Wrong value");
            }
        }

        public Door()
        {
            DoorWidth = 0.9;
            DoorHeight = 2.05;
        }
        public Door(double width, double height) : this()
        {
            DoorWidth = width;
            DoorHeight = height;
        }

        internal double DoorArea()
        {
            return Math.Round((DoorWidth * DoorHeight), 2);
        }
    }
}
