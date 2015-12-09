using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Radio
    {
        int volume;
        double frequencies;
        bool isOn; //false default
        static int instanceCount;

        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if (value <= 0 || value >= 100)
                    throw new Exception("Wrong value. Range of Volume 0 - 100.");
                volume = value;
            }
        }
        public double Frequencies
        {
            get
            {
                return frequencies;
            }

            set
            {
                if (value <= 87.5 || value >= 108.00)
                    throw new Exception("Wrong value. Range of frenqencies.");
                frequencies = value;
            }
        }
        public bool IsOn
        {
            get
            {
                return isOn;
            }

            set
            {
                isOn = value;
            }
        }
        public static int InstanceCount 
        {
            get
            {
                return instanceCount;
            }
        private set
            {
                instanceCount = value;
            } //set is private b.o. read-only
        } 

        static Radio()
        {
            InstanceCount = 0;
        }
        public Radio()
        {
            //Volume = 20;
            Frequencies = 96.9;
            //IsOn = false;
            instanceCount++;
        }
        public Radio(int volume) : this()
        {
            Volume = volume;
        }
        public Radio(int volume, double frequencies) : this(volume)
        {
            //Volume = Volume;
            Frequencies = frequencies;
            //IsOn = isOn;  ??
        }
        public override string ToString() => $"Volume: {Volume}, IsOn: {IsOn}, Frequencies: {Frequencies}, Instance: {InstanceCount};";
       
    }
}
