using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Car
    {
        string mark;
        int numberOfGears;
        string color;
        string typ;

        public string Mark
        {
            get
            {
                return mark;
            }

            set
            {
                mark = value;
            }
        }

        public int NumberOfGears
        {
            get
            {
                return numberOfGears;
            }

            set
            {
                numberOfGears = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Typ
        {
            get
            {
                return typ;
            }

            set
            {
                if (value != "cupe" && value != "combi")
                    throw new Exception("Wrong value. Only 'cupe' och 'combi'.");
                typ = value;
            }
        }
        public override string ToString() => $"Mark: {Mark}, Number of Gears: {NumberOfGears}, Color: {Color}, Typ {Typ};";
        
    }
}
