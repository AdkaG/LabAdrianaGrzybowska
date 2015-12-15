using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift_1();
            //Uppgift_2();
            //Uppgift_3();
            Uppgift_4();

            Console.ReadLine();
        }

        private static void Uppgift_4()
        {
            Console.WriteLine("*** Uppgift 4 ***");
            MyDoubleType mdt1 = new MyDoubleType(3);
            MyDoubleType mdt2 = mdt1 + 5;
            MyDoubleType mdt3 = 5 + mdt1;
            MyDoubleType mdt4 = mdt1 + mdt2;
            MyDoubleType mdt5 = mdt4 - 4;
            MyDoubleType mdt6 = 20 - mdt4;
            MyDoubleType mdt7 = mdt4 - mdt1;
            MyDoubleType mdt8 = mdt1*3;
            MyDoubleType mdt9 = 5*mdt2;
            MyDoubleType mdt10 = mdt1*mdt2;
            MyDoubleType mdt11 = mdt10/2;
            MyDoubleType mdt12 = 48/mdt11;
            MyDoubleType mdt13 = mdt3/mdt10;

            Console.WriteLine($"mdt1: {mdt1}");
            Console.WriteLine($"mdt2: {mdt2}");
            Console.WriteLine($"mdt3: {mdt3}");
            Console.WriteLine($"mdt4: {mdt4}");
            Console.WriteLine($"mdt5: {mdt5}");
            Console.WriteLine($"mdt6: {mdt6}");
            Console.WriteLine($"mdt7: {mdt7}");
            Console.WriteLine($"mdt8: {mdt8}");
            Console.WriteLine($"mdt9: {mdt9}");
            Console.WriteLine($"mdt10: {mdt10}");
            Console.WriteLine($"mdt11: {mdt11}");
            Console.WriteLine($"mdt12: {mdt12}");
            Console.WriteLine($"mdt13: {mdt13}");
            Console.WriteLine($"mdt1 == mdt3: {mdt1 == mdt3}");
            Console.WriteLine($"mdt2 != mdt5: {mdt2 != mdt5}");
            Console.WriteLine($"mdt6 > mdt7: {mdt6 > mdt7}");
            Console.WriteLine($"mdt11 < mdt12: {mdt11 < mdt12}");
            Console.WriteLine($"mdt4 >= mdt8: {mdt4 >= mdt8}");
            Console.WriteLine($"mdt2 <= mdt12: {mdt2 <= mdt12}");
        }

        private static void Uppgift_3()
        {
            Console.WriteLine("*** Uppgift 3 ***");
            Point point = new Point(x: 3, y: 5);
            Point3D point3D = point;
            Console.WriteLine(point3D);
            Console.WriteLine();
        }
        private static void Uppgift_2()
        {
            Console.WriteLine("*** Uppgift 2 ***");
            int firstNumber = 7;
            int secondNumber = 13;
            //first number: 0111; second number: 1101

            int resultAnd = firstNumber & secondNumber; //0111 & 1101 = 0101 (5)
            int resultOr = firstNumber | secondNumber; //0111 | 1101 = 1111 (15)
            int resultXor = firstNumber ^ secondNumber; //0111 ^ 1101 = 1010 (10)

            int resultRightShift = firstNumber >> 1; //0111 => 0011 (3)
            int resultLeftShift = firstNumber << 1; //0111 => 1110 (14)
            int resultRightShift2 = firstNumber >> 3; //0111 => 0000 (0)
            int resultLeftShift2 = firstNumber << 3; //0111 => 111000 (56)

            Console.WriteLine(resultAnd);
            Console.WriteLine(resultOr);
            Console.WriteLine(resultXor);
            Console.WriteLine(resultRightShift);
            Console.WriteLine(resultLeftShift);
            Console.WriteLine(resultRightShift2);
            Console.WriteLine(resultLeftShift2);
            Console.WriteLine();
        }
        private static void Uppgift_1()
        {
            Console.WriteLine("*** Uppgift 1 ***");
            float myFloat = 7.22f;
            long myLong = 232L;
            char myChar = 'a';
            string myString = "my string";
            ulong myULong = 2345UL;
            Console.WriteLine();
        }
    }
}
