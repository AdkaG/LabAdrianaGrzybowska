using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Wallpaper
    {
        double width;
        double length;
        double pris;
        string pattern;

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value >= 0.30 && value <= 0.70)
                    width = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value >= 8 && value <= 20)
                    length = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double Pris
        {
            get
            {
                return pris;
            }

            set
            {
                pris = value;
            }
        }
        public string Pattern
        {
            get
            {
                return pattern;
            }

            set
            {
                if (value != null)
                    pattern = value;
                else
                    throw new Exception("Wrong value");
            }
        }

        public Wallpaper()
        {
            Width = 0.53;
            Length = 10.05;
        }
        public Wallpaper(double width, double length) : this()
        {
            Width = width;
            Length = length;
        }
        public Wallpaper(double width, double length, double pris) : this()
        {
            Width = width;
            Length = length;
            Pris = pris;  //Pris/pris?
        }
        public Wallpaper(double width, double length, double pris, string pattern) : this()
        {

            Width = width;
            Length = length;
            Pris = pris;  //Pris/pris?
            Pattern = pattern;
        }

        private double TotalWallpaperLength(Room room)
        {
            double totalWallpaperLength = Math.Round(((((2 * room.RoomWidth) + (2 * room.RoomLength)) / Width) * room.RoomHeight),2);
            return totalWallpaperLength;
        }
        private int RollNumberPerRoom(Room room)
        {

            double numberOfRolls = TotalWallpaperLength(room) / Length;
            return Convert.ToInt32(numberOfRolls) + 1;
        }
        private double TotalPaperhangingCost(Room room)
        {
            return RollNumberPerRoom(room) * Pris;
        }
        public void PrintPaperhangingInformation(Room room)
        {
            Console.WriteLine($"For your room you'll need:\n\bNumber of wallpaper meters: {TotalWallpaperLength(room)}\n\bNumber of wallpaper rolls: {RollNumberPerRoom(room)}\n\bTOTAL COST: {TotalPaperhangingCost(room)}");
        }
    }
}
