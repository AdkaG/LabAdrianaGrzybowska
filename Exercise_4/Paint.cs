using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Paint
    {
        string color;
        double pricePerCan;
        double capacity;
        double efficiencyMeterPerLiter;
        int layersNumber;

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                var validValue = value != null;
                if (validValue)
                    color = value;
                else
                    throw new Exception("Wrong value");
            }
        }//warunki
        public double PricePerCan
        {
            get
            {
                return pricePerCan;
            }

            set
            {
                var validValue = value >= 20 && value <= 1000;
                if (validValue)
                    pricePerCan = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                var validValue = value >= 0.2 && value <= 20;
                if (validValue)
                    capacity = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double EfficiencyMeterPerLiter
        {
            get
            {
                return efficiencyMeterPerLiter;
            }

            set
            {
                var validValue = value >= 4 && value <= 20;
                if (validValue)
                    efficiencyMeterPerLiter = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public int LayersNumber
        {
            get
            {
                return layersNumber;
            }

            set
            {
                var validValue = value >= 1 && value <= 3;
                if (validValue)
                    layersNumber = value;
                else
                    throw new Exception("Wrong value");
            }
        }

        public Paint()
        {
            Color = "white";
            PricePerCan = 119.00;
            Capacity = 2.5;
            EfficiencyMeterPerLiter = 8;
            LayersNumber = 2;
        }
        public Paint(string color, double pricePerCan, double Capacity, double efficiencyMeterPerLiter, int layersNumber) : this()
        {
            Color = color;
            PricePerCan = pricePerCan;
            Capacity = capacity;
            EfficiencyMeterPerLiter = efficiencyMeterPerLiter;
            LayersNumber = layersNumber;
        }
        internal double PricePerLiter()
        {
            return PricePerCan / Capacity;
        }

    }
}
