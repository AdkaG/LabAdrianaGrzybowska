using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Window
    {
        double windowWidth;
        double windowHeight;

        public double WindowWidth
        {
            get
            {
                return windowWidth;
            }

            set
            {
                if (value >= 0.1)
                    windowWidth = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double WindowHeight
        {
            get
            {
                return windowHeight;
            }

            set
            {
                if (value >= 0.1)
                    windowHeight = value;
                else
                    throw new Exception("Wrong value");
            }
        }

        public Window()
        {
            WindowWidth = 0.80;
            WindowHeight = 1.00;
        }
        public Window(double windowWidth, double windowHeight) : this()
        {
            WindowWidth = windowWidth;
            WindowHeight = windowHeight;
        }

        internal double WindowArea()
        {
            return Math.Round((WindowWidth * WindowHeight), 2);
        }

    }
}
