using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class MyDoubleType
    {
        private double doubleValue;

        public double DoubleValue
        {
            get { return doubleValue; }
            private set { doubleValue = value; }
        }

       public MyDoubleType(double myDouble)
        {
            DoubleValue = myDouble;
        }

        //operator "+"
        public static MyDoubleType operator +(MyDoubleType myDouble, double doubleNumber)
        {
            return new MyDoubleType(myDouble.DoubleValue + doubleNumber);
        }
        public static MyDoubleType operator +(double doubleNumber, MyDoubleType myDouble)
        {
            return new MyDoubleType(doubleNumber + myDouble.DoubleValue);
        }
        public static MyDoubleType operator +(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return new MyDoubleType(myDoubleOne.DoubleValue + myDoubleTwo.DoubleValue);
        }

        //operator "-"
        public static MyDoubleType operator -(MyDoubleType myDouble, double doubleNumber)
        {
            return new MyDoubleType(myDouble.DoubleValue - doubleNumber);
        }
        public static MyDoubleType operator -(double doubleNumber, MyDoubleType myDouble)
        {
            return new MyDoubleType(doubleNumber - myDouble.DoubleValue);
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return new MyDoubleType(myDoubleOne.DoubleValue - myDoubleTwo.DoubleValue);
        }

        //operator "*"
        public static MyDoubleType operator *(MyDoubleType myDouble, double doubleNumber)
        {
            return new MyDoubleType(myDouble.DoubleValue * doubleNumber);
        }
        public static MyDoubleType operator *(double doubleNumber, MyDoubleType myDouble)
        {
            return new MyDoubleType(doubleNumber * myDouble.DoubleValue);
        }
        public static MyDoubleType operator *(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return new MyDoubleType(myDoubleOne.DoubleValue*myDoubleTwo.DoubleValue);
        }

        //operator "/"
        public static MyDoubleType operator /(MyDoubleType myDouble, double doubleNumber)
        {if(doubleNumber != 0.00)
            return new MyDoubleType(myDouble.DoubleValue / doubleNumber);
        else
        {
           throw new Exception("You can't devide by zero.");
        }
        }
        public static MyDoubleType operator /(double doubleNumber, MyDoubleType myDouble)
        {
            if (myDouble.DoubleValue != 0.00)
                return new MyDoubleType(doubleNumber / myDouble.DoubleValue);
            else
            {
                throw new Exception("You can't devide by zero.");
            }
        }
        public static MyDoubleType operator /(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            if(myDoubleTwo.DoubleValue != 0.00)
            return new MyDoubleType(myDoubleOne.DoubleValue / myDoubleTwo.DoubleValue);
            else
            {
                throw new Exception("You can't devide by zero.");
            }
        }

        //operators "==" and "!="
        public static bool operator ==(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return myDoubleOne.DoubleValue == myDoubleTwo.DoubleValue;
        }
        public static bool operator !=(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return myDoubleOne.DoubleValue != myDoubleTwo.DoubleValue;
        }

        //operators ">" and "<"
        public static bool operator >(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return myDoubleOne.DoubleValue > myDoubleTwo.DoubleValue;
        }
        public static bool operator <(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return myDoubleOne.DoubleValue < myDoubleTwo.DoubleValue;
        }

        //operators ">=" and "<="
        public static bool operator >=(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return myDoubleOne.DoubleValue >= myDoubleTwo.DoubleValue;
        }
        public static bool operator <=(MyDoubleType myDoubleOne, MyDoubleType myDoubleTwo)
        {
            return myDoubleOne.DoubleValue <= myDoubleTwo.DoubleValue;
        }

        public override string ToString() => $"DoubleValue: {DoubleValue}";
    }
}
