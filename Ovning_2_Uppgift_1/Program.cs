using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_2_Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float dowJonesRate = -4.6f;
            float nasdaqRate = -4.1f;
            float stockholmRate = -2.4f;
            float milanoRate = -6.7f;
            float parisRate = -5.5f;
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent. Stockholm {2} procent, Milano {3} procent, Paris {4} procent.", dowJonesRate, nasdaqRate, stockholmRate, milanoRate, parisRate);
            Console.WriteLine();
            dowJonesRate = -3.2f;
            nasdaqRate = 1.7f;
            stockholmRate = 2.2f;
            milanoRate = 3.3f;

            parisRate = 3.7f;
            Console.WriteLine("Dow Jones sjönk med {0} procent och Nasdaq med {1} procent. Stockholm {2} procent, Milano {3} procent, Paris {4} procent.", dowJonesRate, nasdaqRate, stockholmRate, milanoRate, parisRate);
            Console.WriteLine();
            //konstant
            const double piNumber = 3.141592654;
            double piNumberRoundToTwo = Math.Round(piNumber, 2);
            int piNumberToInteger = (int)piNumber;
            Console.WriteLine($"Talet π är cirka {piNumber} men kan avrundas till {piNumberRoundToTwo} och kan lite grovt skrivas som {piNumberToInteger}.");
            Console.WriteLine();

             
            string sex = "Han";
            string name = "Jonas";
            string city = "Helsingborg";
            string region = "Stattena";
            string specialPlace = "Hemköp";
            Console.WriteLine("{0} heter {1} och bor i {2} på {3} vid {4}.", sex, name, city, region, specialPlace);
            Console.WriteLine();
            sex = "Hon";
            name = "Jack";
            city = "Warszawa";
            region = "Mokotow";
            specialPlace = "Aldo";
            Console.WriteLine("{0} heter {1} och bor i {2} på {3} vid {4}.", sex, name, city, region, specialPlace);
            Console.ReadLine();



        }
    }
}

//Dow Jones sjönk med 4,6 procent och Nasdaq med 4,1 procent.Stockholm -2,4 procent, Milano -6,7 procent, Paris -5,5 procent.
//Talet π är cirka 3.141592654 men kan avrundas till 3.14 och kan lite grovt skrivas som 3.
//Han heter Jonas och bor i Helsingborg på Stattena vid Hemköp.
