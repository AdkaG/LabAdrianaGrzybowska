using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_4;



namespace Arv_Abstract_Is_As
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift_1();
            //Uppgift_2();
            //Uppgift_3();
            //Uppgift_4();
            //Uppgift_5();

            //Animal animal = new Animal();
            Cat myCat = new Cat();
            Console.WriteLine(myCat.GetSound());
            Console.WriteLine(myCat.GetMaximumSpeed());
            Bengal myBengal = new Bengal();
            Console.WriteLine(myBengal.GetSound());
            Console.WriteLine(myBengal.GetMaximumSpeed());
           

            Console.ReadLine();
        }

        private static void Uppgift_5()
        {
            SUV mySuv = new SUV();
            mySuv.Drive();
            Car myCar = mySuv;
            myCar.Drive();
            SUV mySuv1 = (SUV)myCar;
            mySuv1.Drive();
        }

        private static void Uppgift_4()
        {
            A myA = new A();
            B myB = new B();
            C myC = new C();
        }

        private static void Uppgift_3()
        {
            Console.WriteLine("***   Uppgift 3   ***");
            Point3D myPoint = new Point3D(x: 3, y: 5, z: 7);
            Console.WriteLine(myPoint);
        }

        private static void Uppgift_2()
        {
            Console.WriteLine("***   Uppgift 2   ***");
            Point3D myPoint = new Point3D(3);
            myPoint.X = 2;
            myPoint.Y = 7;
            myPoint.Z = 9;
            Console.WriteLine("Properties:");
            Console.WriteLine($"X: {myPoint.X}, Y: {myPoint.Y}, Z: {myPoint.Z}");
            Console.WriteLine();
            myPoint.SetX(4);
            myPoint.SetY(5);
            myPoint.Z = 7;
            Console.WriteLine("Get/Set methods:");
            Console.WriteLine($"X: {myPoint.GetX()}, Y: {myPoint.GetY()}, Z: {myPoint.Z}");
        }

        private static void Uppgift_1()
        {
            Console.WriteLine("***   Uppgift 1   ***");
            object myObj = new object();
            string myString = "My string";
            int myInt = 77;
            double myDouble = 3.43;
            char myChar = '4';
            bool myBool = true;
            object myObj2 = new object();
            object myObj3 = new object();
            MyObjKonverteringar(myString, myInt, myDouble, myChar, myBool);
            MyStringKonverteringar(myInt, myDouble, myChar, myBool);
            MyIntKonverteringar(myDouble, myChar);

            //myChar = Convert.ToChar(myString);
            //myChar = myBool;
            //Console.WriteLine(myChar);

            //myBool = (bool) myObj3;
            //myBool = Convert.ToBoolean(myString);
            //myBool = myInt;
            //Console.WriteLine(myBool);
        }

        private static void MyIntKonverteringar(double myDouble, char myChar)
        {
            object myObj3;
            myObj3 = 77;
            //int myInt1 = int.Parse(myObj2);
            //int myInt2 = int.Parse(myString);
            int myInt3 = (int)myDouble;
            int myInt4 = int.Parse(myChar.ToString());
            //int myInt5 = int.Parse(myBool.ToString());

            //Console.WriteLine(myInt2);
            Console.WriteLine(myInt3);
            Console.WriteLine(myInt4);
            //Console.WriteLine(myInt5);
        }

        private static void MyStringKonverteringar(int myInt, double myDouble, char myChar, bool myBool)
        {
            //myString = (string) myObj2;
            //string myString2 = (string) myObj2;
            Console.WriteLine("myString = myObj => Unable to cast object of type 'System.Object' to type 'System.String'.");
            //myString = myInt;
            string myString3 = myInt.ToString();
            Console.WriteLine("myString = myInt  =>  myString: {0}; method: ToString().", myString3);
            //myString = myDouble;
            string myString4 = myDouble.ToString();
            Console.WriteLine("myString = myDouble  =>  myString: {0}; method: ToString().", myString4);
            //myString = myChar;
            string myString5 = myChar.ToString();
            Console.WriteLine("myString = myChar  =>  myString: {0}; method: ToString().", myString5);
            //myString = myBool;
            string myString6 = myBool.ToString();
            Console.WriteLine("myString = myBool  =>  myString: {0}; method: ToString().", myString6);
            Console.WriteLine();
        }

        private static void MyObjKonverteringar(string myString, int myInt, double myDouble, char myChar, bool myBool)
        {
            object myObj;
            myObj = myString;
            Console.WriteLine("myObj = myString  =>  myObj: {0}", myObj);
            myObj = myInt;
            Console.WriteLine("myObj = myInt  =>  myObj: {0}", myObj);
            myObj = myDouble;
            Console.WriteLine("myObj = myDouble  =>  myObj: {0}", myObj);
            myObj = myChar;
            Console.WriteLine("myObj = myChar  =>  myObj: {0}", myObj);
            myObj = myBool;
            Console.WriteLine("myObj = myBool  =>  myObj: {0}", myObj);
            Console.WriteLine();
        }
    }
}
