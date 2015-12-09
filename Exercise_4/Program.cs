using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryCar();
            TryRadio();
              TryRoom();

            Console.ReadLine();
        }

        private static void TryRoom()
        {
            Room room = new Room();
            Console.WriteLine("***** 1 room *****");
            Console.WriteLine(room.ToString());
            Console.WriteLine();

            Console.WriteLine("***** 2 room *****");
            Room room2 = new Room(3, 4, 5, 2, 1);
            Console.WriteLine(room2.ToString());
            Console.WriteLine();
            Paint wallPaint = new Paint("grey", 65.50, 1.0, 8, 3);
            room2.PaintWalls(wallPaint);
            Paint ceilingPaint = new Paint();
            room2.PaintCeiling(ceilingPaint);
            room2.PrintRenovationCalculation(wallPaint, ceilingPaint);
            Console.WriteLine();
            Wallpaper wallpaper = new Wallpaper { Pris = 99.00 };
            wallpaper.PrintPaperhangingInformation(room2);
            Console.WriteLine();
        }
        private static void TryRadio()
        {

            Radio radio = new Radio();
            Console.WriteLine(radio.ToString());
            Radio radio2 = new Radio { Volume = 17};
            Console.WriteLine(radio2.ToString());
            Radio radio3 = new Radio { Volume = 33, Frequencies = 88.8};
            Console.WriteLine(radio3.ToString());
            Radio radio4 = new Radio { Volume = 93, Frequencies = 106.7, IsOn = true };            
            Console.WriteLine(radio4.ToString());
            Radio radio5 = new Radio(45, 96.3);
            Console.WriteLine(radio5.ToString());
            Console.WriteLine($"There is {Radio.InstanceCount} instances of Radio Class.");
        }
        private static void TryCar()
        {
            Car car = new Car();
            Car car2 = new Car();
            car.Typ = "combi";
            //car2.Typ = "suv";//throws ex.
            car2.Typ = "cupe";
            Console.WriteLine(car.ToString());
            Console.WriteLine(car2.ToString());
        }
    }
}
