using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift_1();
            //Uppgift_2();
            //Uppgift_4();
            //Uppgift_5();

            //TryCrazyCircles();
            Circle circle = new Circle();
            circle.CrazyCirclesMenu();


            Console.ReadLine();



        }

        private static void TryCrazyCircles()
        {
            Console.WriteLine(@"***  Bonusupgift  ***");
            Circle circle = new Circle();
            Circle[] circleArray = circle.CreateCirclesWithRandomDiameters();
            Console.WriteLine();
            Console.WriteLine(@"***  Diameter between 7 - 17  ***");
            circle.PrintSelectedDiameters(circleArray, 7, 17);
            Console.WriteLine();
            Console.WriteLine(@"***   Circumference between 2 - 22  ***");
            circle.PrintSelectedCircumference(circleArray, 2, 22);
            Console.WriteLine();
            Console.WriteLine(@"***   Circumference distance from origin less than 12  ***");
            circle.ChangeDiameterToOrigin1(circleArray, 12);
            Console.WriteLine();
            Console.WriteLine(@"***   Opposite coordinates  ***");
            circle.oppositeCoordinates(circleArray);
            Console.WriteLine();
            Console.WriteLine(@"***   Cirkles in circle  ***");
            circle.CirclesInCircle(circleArray, 2, 4);
            Console.WriteLine();
            Console.WriteLine(@"***   Circles with greater area  ***");
            circle.CirclesWithGreaterArea(circleArray);
        }

        private static void Uppgift_5()
        {
            Console.WriteLine(@"***  Uppgift 5   ***");
            School mySchool = new School();
            mySchool.SetName("ECUtbildning");
            mySchool.SetNumberOfClass(3);
            mySchool.SetArea(1500);
            Console.WriteLine("{0} is my school. There is {1} classrooms. Total area of all school including corridors and kitchen is {2}.", mySchool.GetName(), mySchool.GetNumberOfClass(), mySchool.GetArea());

            ClassRoom celsius = new ClassRoom();
            celsius.SetName("Celsius");
            celsius.SetArea(30.5);
            celsius.SetNumberOfPlaces(40);
            ClassRoom gauss = new ClassRoom();
            gauss.SetName("Gauss");
            gauss.SetArea(44.5);
            gauss.SetNumberOfPlaces(38);
            ClassRoom newton = new ClassRoom();
            celsius.SetName("Newton");
            newton.SetArea(31.5);
            newton.SetNumberOfPlaces(35);

            Console.WriteLine("I usually have classes in {0} which area is {1} and which can accommodate up to {2} persons.", gauss.GetName(), gauss.GetArea(), gauss.GetNumberOfPlaces());

            double totalArea = mySchool.ClassRoomsArea(celsius, gauss, newton);
            Console.WriteLine($"Total area of all classrooms in this school is {totalArea}.");


            Teacher myTeacher1 = new Teacher();
            myTeacher1.SetName("Agnes");
            myTeacher1.SetAge(39);
            myTeacher1.SetSalary(36500);
            Teacher myTeacher2 = new Teacher();
            myTeacher2.SetName("Lars");
            myTeacher2.SetAge(44);
            myTeacher2.SetSalary(38300);
            Teacher myTeacher3 = new Teacher();
            myTeacher3.SetName("Ebba");
            myTeacher3.SetAge(27);
            myTeacher3.SetSalary(35200);
            double averageTeachersAge = mySchool.AverageTeachersAge(myTeacher1, myTeacher2, myTeacher3);
            Console.WriteLine($"The average teachers' age in my school is {averageTeachersAge}.");
            Console.WriteLine($"The average teachers' salary in my school is {mySchool.AverageTeachersSalary(myTeacher1, myTeacher2, myTeacher3)}.");
            Console.WriteLine("Press enter to continue to Bonusupgift.");
            Console.ReadLine();
        }

        private static void Uppgift_4()
        {
            Console.WriteLine(@"***  Uppgift 4   ***");
            Point myPoint = new Point();
            myPoint.SetX(20);
            myPoint.SetY(10);
            Circle myNewCircle = new Circle();
            myNewCircle.SetDiameter(40);
            myNewCircle.SetPoint(myPoint);
            Console.WriteLine($"The diameter of circle is: {myNewCircle.GetDiameter()}\b\nThe central point of the circle has coordinates: x: {myPoint.GetX()}, y: {myPoint.GetY()}");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        private static void Uppgift_2()
        {
            Console.WriteLine(@"***  Uppgift 2   ***");
            Circle circel = new Circle();
            circel.SetDiameter(4);
            Console.WriteLine($"Circumference of the circle with diameter {circel.GetDiameter()}: {circel.GetCircumference()}.");
            Circle myCircle2 = new Circle();
            myCircle2.SetDiameter(17);
            Console.WriteLine($"Circumference of the circle with diameter {myCircle2.GetDiameter()}: {myCircle2.GetCircumference()}.");
            Console.WriteLine();
            Console.WriteLine("Enter diameter for your circle: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            Circle usersCircle = new Circle();
            usersCircle.SetDiameter(diameter);
            Console.WriteLine($"Circumference of the circle with diameter {usersCircle.GetDiameter()}: {usersCircle.GetCircumference()}.");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        private static void Uppgift_1()
        {
            Console.WriteLine(@"***  Uppgift 1   ***");
            Person sofia = new Person();
            //myPerson.SetName("Sofia");
            //Console.WriteLine(myPerson.GetName());
            Person jack = new Person();
            //myPerson.SetName("Jack");
            //Console.WriteLine(myPerson.GetName());
            Person hanna = new Person();
            //myPerson.SetName("Hanna");
            //Console.WriteLine(myPerson.GetName());

            sofia.Name = "Sofia";
            Console.WriteLine(sofia.Name);
            jack.Name = "Jack";
            Console.WriteLine(jack.Name);
            hanna.Name = "Hanna";
            Console.WriteLine(hanna.Name);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}


