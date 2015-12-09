using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Room
    {
        double roomWidth;
        double roomLength;
        double roomHeight;
        const int numberOfWalls = 4;//?
        int windowsNumber;
        int doorsNumber;
        Window window;
        Door door;
        double totalWindowsArea;
        double totalDoorsArea;

        public double RoomWidth
        {
            get
            {
                return roomWidth;
            }

            set
            {
                var validValue = value >= 1;
                if (validValue)
                    roomWidth = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double RoomLength
        {
            get
            {
                return roomLength;
            }

            set
            {
                var validValue = value >= 1;
                if (validValue)
                    roomLength = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public double RoomHeight
        {
            get
            {
                return roomHeight;
            }

            set
            {
                var validValue = value >= 2;
                if (validValue)
                    roomHeight = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public int WindowsNumber
        {
            get
            {
                return windowsNumber;
            }

            set
            {
                var validValue = value >= 0;
                if (validValue)
                    windowsNumber = value;
                else
                    throw new Exception("Wrong value");
            }
        }
        public int DoorsNumber
        {
            get
            {
                return doorsNumber;
            }

            set
            {
                var validValue = value >= 1;
                if (validValue)
                    doorsNumber = value;
                else
                    throw new Exception("Wrong value");
            }
        }

        public Room()
        {
            RoomWidth = 3.00;
            RoomLength = 4.00;
            RoomHeight = 2.46;
            DoorsNumber = 1;
            SetDoorsTotalArea();
        }
        public Room(double roomWidth, double roomLength, double roomHeight, int windowsNumber, int doorsNumber) : this()
        {
            RoomWidth = roomWidth;
            RoomLength = roomLength;
            RoomHeight = roomHeight;
            WindowsNumber = windowsNumber;
            SetWindowsTotalArea();
            DoorsNumber = doorsNumber;
            
        }
        private void SetWindowsTotalArea()
        {
            if (WindowsNumber > 0)
            {
                Window[] windowsArray = new Window[WindowsNumber];
                totalWindowsArea = 0;
                for (int i = 0; i < windowsArray.Length; i++)
                {
                    window = new Window();
                    windowsArray[i] = window;
                    Console.WriteLine($"Enter width for {i + 1} window.");
                    windowsArray[i].WindowWidth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Enter height for {i + 1} window.");
                    windowsArray[i].WindowHeight = Convert.ToDouble(Console.ReadLine());
                    double windowArea = windowsArray[i].WindowArea();
                    totalWindowsArea += windowArea;
                }
            }
        }
        private void SetDoorsTotalArea()
        {
            if (DoorsNumber > 0)
            {
                Door[] doorsArray = new Door[DoorsNumber];
                for (int i = 0; i < doorsArray.Length; i++)
                {
                    door = new Door();
                    doorsArray[i] = door;
                    Console.WriteLine($"Enetr width for {i + 1} door.");
                    doorsArray[i].DoorWidth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Enter height for {i + 1} door.");
                    doorsArray[i].DoorHeight = Convert.ToDouble(Console.ReadLine());
                    double doorArea = doorsArray[i].DoorArea();
                    totalDoorsArea += doorArea;
                }
            }
        }
        private double WallArea()
        {
            return (2 * (RoomWidth * RoomHeight)) + (2 * (RoomLength * RoomHeight));
        }
        private double CeilingArea()
        {
            return Math.Round((RoomWidth * RoomLength), 2);
        }
        internal double WallRenovationArea()
        {

            return Math.Round((WallArea() - (totalWindowsArea + totalDoorsArea)), 2);
        }
        

        public override string ToString() => $"Room width: {RoomWidth}\n\bRoom length: {RoomLength}\n\bRoom height: {RoomHeight}\n\bWalls area: {WallArea()}\n\bWindows number: {WindowsNumber}\n\bDoors number: {DoorsNumber}\n\bWindows area: {totalWindowsArea}\n\bDoors area: {totalDoorsArea}\n\bRenovation area: {WallRenovationArea()}\n\bCeilingArea: {CeilingArea()}";
        public void PaintWalls(Paint wallPaint)
        {
            Console.WriteLine($"   ---  Walls Painting Info  ---\n\bColor: {wallPaint.Color}\n\bPrice {wallPaint.PricePerCan}\n\bEfficiency per liter: {wallPaint.EfficiencyMeterPerLiter} meters\n\bNumber of required layers: {wallPaint.LayersNumber}");
        }
        public void PaintCeiling(Paint ceilingPaint)
        {
            Console.WriteLine($"   ---  Ceiling Painting Info  ---\n\bColor: {ceilingPaint.Color}\n\bPrice {ceilingPaint.PricePerCan}\n\bEfficiency per liter: {ceilingPaint.EfficiencyMeterPerLiter} meters\n\bNumber of required layers: {ceilingPaint.LayersNumber}");
        }
        public void PrintRenovationCalculation(Paint wallPaint, Paint ceilingPaint)
        {
            Console.WriteLine($"   ---  TOTAL COST  ---\n\bWall renovation cost: {WallRenovationCalculation(wallPaint)}\n\bCeiling renovation cost: {CeilingRenovationCalculation(ceilingPaint)}\n\bTotal cost: {WallRenovationCalculation(wallPaint) + CeilingRenovationCalculation(ceilingPaint)}\n\b");
        }
        private double WallRenovationCalculation(Paint paint)
        {
            int numberOfLiters = Convert.ToInt32((WallRenovationArea() / paint.EfficiencyMeterPerLiter) * paint.LayersNumber) + 1;
            double cost = numberOfLiters * paint.PricePerLiter();
            return cost;
        }
        private double CeilingRenovationCalculation(Paint paint)
        {
            int numberOfLiters = Convert.ToInt32((CeilingArea() / paint.EfficiencyMeterPerLiter) * paint.LayersNumber) + 1;
            double cost = numberOfLiters * paint.PricePerLiter();
            return cost;
        }

        //public void PrintPaperhangingCalculation(Wallpaper wallpaper)
        //{

        //}
        //private double 
    }
}


