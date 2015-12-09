using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Uppgift_1();
            Uppgift_2();
            Uppgift_3();
            Uppgift_4();
            Uppgift_5();
            Uppgift_6();
            Console.ReadLine();
        }

        private static void Uppgift_6()
        {
            Program program = new Program();
            int x = 1;
            program.MyRecursion(ref x);
        }
        private void MyRecursion(ref int myInt)
        {
            Console.WriteLine(myInt);
            myInt++;
            if (myInt < 10)
            {
                MyRecursion(ref myInt);
            }
         
        }
        private static void Uppgift_5()
        {
            Program program = new Program();
            program.Params("Aaa", "Bbb", "Ccc", "Ddd", "Eee", "Fff", "Ggg");
            Console.WriteLine();
        }
        private void Params(params string[] strings)
        {
            foreach (var element in strings)
            {
                Console.Write($"{element}, ");
            }
            
        }
        private static void Uppgift_4()
        {
            Program program = new Program();
            program.numberTest(2);
            program.numberTest(4);
            program.numberTest(0);
            program.numberTest(-22);
            program.numberTest(-7);
            program.numberTest(8);
        }

        private void numberTest(int number)
        {
            if(number < 0)
                Console.WriteLine($"Number {number} is negative.");
            else if(number == 0)
                Console.WriteLine($"Number {number} is = 0.");
            else
                Console.WriteLine($"Number {number} is positive.");
        }
        private static void Uppgift_3()
        {
            Program program = new Program();
            int x = 5;
            int y = 10;
            int result;
            program.Add(x, y, out result);
            Console.WriteLine($"Add Out result: {result}");
            program.Multiply(x, y, out result);
            Console.WriteLine($"Multiply Out result: {result}");
            program.Add(3, 7, out result);
            Console.WriteLine($"Add Out result with 3, 7: {result}");
            program.Multiply(3, 7, out result);
            Console.WriteLine($"Multiply Out result with 3, 7: {result}");
        }

        private void Add(int x, int y, out int resultat)
        {
            resultat = x + y;
        }

        private void Multiply(int x, int y, out int resultat)
        {
            resultat = x*y;
        }
        private static void Uppgift_2()
        {
            Program program = new Program();
            int myInt = 5;
            program.Add(ref myInt);
            program.Multiply(ref myInt);
            Console.WriteLine($"Ref: {myInt}");
        }

        private void Add(ref int number)
        {
            number += 10;
        }

        private void Multiply(ref int number)
        {
            number *= 10;
        }

        private static void Uppgift_1()
        {
            Program program = new Program();
            int myInt = 5;
            myInt = program.Add(myInt);
            myInt = program.Multiply(myInt);
            Console.WriteLine($"Zwykle metody:{myInt}");
        }

        private int Add(int number)
        {
            return number += 10;
        }

        private int Multiply(int number)
        {
            return number*=10;
        }
        
    }
}
/*

*/

//Program program = new Program();//man måste skapa en ny instans av klass Program för att metoder är privata per default och kan inte anropas som statiska;
//int myInt, operand1, operand2;
//myInt = 5;
//            //operand1 = 5;
//            //operand2 = 10;
//            int result;
//program.Add(ref myInt);
//            Console.WriteLine(myInt);

//            program.Add(5, 10, out result);
//            Console.WriteLine(result);

//            program.Multiply(5, 10, out result);
//            Console.WriteLine(result);

//            string answer;
//            IsNumberPositiv(3, out answer);
//            IsNumberPositiv(-6, out answer);
//            IsNumberPositiv(0, out answer);

//string[] stringArray = { "Aaa", "Bbb", "Ccc", "Ddd", "Eee", "Fff", "Ggg", "Hhh", "Iii", "Jjj", "Kkk", "Lll" };
//            PrintStringArray(stringArray);
//Console.WriteLine();
//            int myNumber = 7;
//            MyRecursionMethod(ref myNumber);
//void Add(ref int number)
//{
//    number += 10;
//    //Console.WriteLine(number);
//}
//void Add(int number1, int number2, out int result)
//{
//    result = number1 + number2;
//}
//void Multiply(ref int number)
//{
//    number *= 10;
//    //Console.WriteLine(number);
//}
//void Multiply(int number1, int number2, out int result)
//{
//    result = number1 * number2;
//}
//static void IsNumberPositiv(int number, out string answer)
//{
//    if (number > 0)
//    {
//        answer = "Talet är positivt.";
//        Console.WriteLine(answer);
//    }
//    else if (number < 0)
//    {
//        answer = "Talet är negativt.";
//        Console.WriteLine(answer);
//    }
//    else
//    {
//        answer = "Talet är 0.";
//        Console.WriteLine(answer);
//    }
//}
//static void PrintStringArray(string[] stringArray)
//{
//    foreach (string element in stringArray)
//    {
//        Console.Write(element + ", ");
//    }
//}
//static void MyRecursionMethod(ref int number)
//{
//    Console.WriteLine(number);
//    number++;
//    if (number < 10)
//    {
//        MyRecursionMethod(ref number);
//    }
//}