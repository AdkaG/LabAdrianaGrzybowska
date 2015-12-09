using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    class Circle
    {
        double diameter;
        Point point;
        Circle[] circleArray;

        public double GetDiameter()
        {
            return diameter;
        }
        public void SetDiameter(double diameter)
        {
            this.diameter = diameter;
        }
        //public void SetDiameter(string diameter)
        //{
        //    this.diameter = Double.Parse(diameter);
        //}
        public double GetCircumference()
        {
            return Math.Round((Math.PI * diameter), 2);
        }
        public double GetArea()
        {
            return Math.Round((Math.PI * ((diameter / 2) * (diameter / 2))));
        }
        public Point GetPoint()
        {
            return point;
        }
        public void SetPoint(Point point)
        {
            this.point = point;
        }

        public double RandomDouble(double min, double max)
        {
            Random randomDouble = new Random();
            return min + randomDouble.NextDouble() * (max - min);
        }
        //BONUSUPPGIFT
        //Fråga användaren hur många Cirkels han vill skapa.Exempelvis 1000st unika Circles med rimliga slumpade värden.Genomför sedan följande:
        public Circle[] CreateCirclesWithRandomDiameters()
        {
            Console.WriteLine("How many circles do you want to create?");
            int amount = int.Parse(Console.ReadLine());

            circleArray = new Circle[amount];
            for (int i = 0; i < amount; i++)

            {
                Circle circle = new Circle();
                double diameter = Math.Round(RandomDouble(1.0, 51.0), 2);
                circle.SetDiameter(diameter);
                Point point = new Point();
                Random randomX = new Random();
                int xPosition = randomX.Next(0, 51);
                point.SetX(xPosition);
                System.Threading.Thread.Sleep(10);
                Random randomY = new Random();
                int yPosition = randomY.Next(0, 51);
                point.SetY(yPosition);
                circle.SetPoint(point);
                circleArray[i] = circle;
                Console.WriteLine($"circleArray {i + 1}: {circle.GetDiameter()}, {point.ToString()}");
                System.Threading.Thread.Sleep(10);
            }
            return circleArray;
        }
        //Skriv ut dem som har en diameter som är mellan 7 och 17
        public void PrintSelectedDiameters(Circle[] circleArray, int min, int max)
        {
            for (int i = 0; i < circleArray.Length; i++)
            {

                if (circleArray[i].GetDiameter() >= min && circleArray[i].GetDiameter() <= max)
                {
                    Point point = circleArray[i].GetPoint();
                    Console.WriteLine($"circleArray {i + 1}: {circleArray[i].GetDiameter()}, {point.ToString()}");
                }
            }
        }
        //Räkna hur många som har en omkrets som är 2 till 22.
        public void PrintSelectedCircumference(Circle[] circleArray, int min, int max)
        {
            int number = 0;
            for (int i = 0; i < circleArray.Length; i++)
            {
                double circumference = circleArray[i].GetCircumference();
                if (circumference >= min && circumference <= max)
                {
                    number++;
                }
            }
            Console.WriteLine($"Number of circle with circumference between {min} i {max}: {number}");
        }

        //De Cirklar som befinner sig kortare sträcka från origo än 12. Ändra deras diameter så att cirkeln kommer att träffa origo om den ritas ut.
        //Version 1 - circumference less than 12 from origin
        public void ChangeDiameterToOrigin1(Circle[] circleArray, int distance)
        {
            for (int i = 0; i < circleArray.Length; i++)
            {
                Point point = circleArray[i].GetPoint();
                int distanceX = point.GetX();
                int distanceY = point.GetY();
                double pointDistanceFromOrigin = Math.Round((Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY))), 2);
                double circumferenceDistanceFromOrigin = pointDistanceFromOrigin - (circleArray[i].GetDiameter() / 2);
                double tempDiameter = circleArray[i].GetDiameter();
                double newDiameter;
                if (circumferenceDistanceFromOrigin < distance)
                {
                    newDiameter = pointDistanceFromOrigin * 2;
                    circleArray[i].SetDiameter(newDiameter);
                    Console.WriteLine($"{point.ToString()}\n\bDiameter: {tempDiameter}\n\bPoint distance from origin: {pointDistanceFromOrigin}\n\bCircumference distance from origin: {circumferenceDistanceFromOrigin}\n\bNew diameter: {newDiameter}");
                    Console.WriteLine();
                }

            }

        }
        //Skapa dubbletter av cirklarna där de nya cirklarna har exakt motsatt koordianter mot ursprungs-cirklarna.
        public void oppositeCoordinates(Circle[] arrayCircle)
        {
            Circle[] newCircleArray = new Circle[circleArray.Length];
            for (int i = 0; i < circleArray.Length; i++)
            {
                Point point = circleArray[i].GetPoint();
                int xCoordinate = point.GetX();
                int yCoordinate = point.GetY();

                newCircleArray[i] = new Circle();
                Point newPoint = new Point();
                newPoint.SetX(xCoordinate * -1);
                newPoint.SetY(yCoordinate * -1);
                newCircleArray[i].SetPoint(newPoint);
                Console.WriteLine();
                Console.WriteLine($"X: {xCoordinate}, Y: {yCoordinate}     newX: {newPoint.GetX()}, newY: {newPoint.GetY()}");

            }

        }
        //Skapa 4st Cirklar per Cirkel som valts. Gör dem maximalt stora och placera dem korrekt i Ursprungscirklarna.
        public void CirclesInCircle(Circle[] circleArray, int circleNumber, int numberOfCircles)
        {
            double originDiameter = circleArray[circleNumber - 1].GetDiameter();
            Point originPoint = circleArray[circleNumber - 1].GetPoint();
            int originX = originPoint.GetX();
            int originY = originPoint.GetY();
            Circle[] circlesInCircle = new Circle[numberOfCircles];
            Console.WriteLine($"Origin circle: diameter: {originDiameter}, x: {originX}, y: {originY}");

            for (int i = 0; i < circlesInCircle.Length; i++)
            {
                Circle circleInCircle = new Circle();
                circlesInCircle[i] = circleInCircle;
                double randomDiameter = Math.Round(RandomDouble(1.0, originDiameter), 2);
                circleInCircle.SetDiameter(randomDiameter);
                circleInCircle.SetPoint(originPoint);
                Console.WriteLine($"New circle: diameter: {randomDiameter}, x: {originX}, y: {originY}");
                System.Threading.Thread.Sleep(10);
            }


        }
        //Fråga användaren efter en area och skriv ut de Cirklar som har en Area som är större än den angivna.
        public void CirclesWithGreaterArea(Circle[] circleArray)
        {
            Console.WriteLine("Specify area size: ");
            double userArea = int.Parse(Console.ReadLine());
            double circleArea;
            for (int i = 0; i < circleArray.Length; i++)
            {
                circleArea = circleArray[i].GetArea();
                if (circleArea > userArea)
                {
                    Point point = circleArray[i].GetPoint();
                    Console.WriteLine($"Circle {i + 1}: diameter: {circleArray[i].GetDiameter()}, {point.ToString()}, area: {circleArea}");
                }
            }
        }
        //Fråga användren efter ett tal och flytta alla cirklarna så mycket som angetts i X-led.
        public void ShiftX(Circle[] circleArray)
        {
            Console.WriteLine("Enter number:");
            int xShift = int.Parse(Console.ReadLine());
            for (int i = 0; i < circleArray.Length; i++)
            {
                Point point = circleArray[i].GetPoint();
                int xCoordinate = point.GetX();
                point.SetX(xCoordinate + xShift);
            }
        }
        //Fråga användren efter ett tal och flytta alla cirklarna så mycket som angetts i Y-led.
        public void ShiftY(Circle[] circleArray)
        {
            Console.WriteLine("Enter number:");
            int yShift = int.Parse(Console.ReadLine());
            for (int i = 0; i < circleArray.Length; i++)
            {
                Point point = circleArray[i].GetPoint();
                int yCoordinate = point.GetY();
                point.SetY(yCoordinate + yShift);
            }
        }

        //Gör en meny så att man kan välja vilken av ovanstående operationer som ska genomföras hur många gånger som helst. Lägg till menyvalet avsluta.
        public void CrazyCirclesMenu()
        {
            Circle circle = new Circle();
            bool loop = true;
            do
            {
                Console.WriteLine("   ***   MENU   ***   ");
                Console.WriteLine("1. Print selected diameters");
                Console.WriteLine("2. How many circles have selected circumference");
                Console.WriteLine("3. Change diameter for circles which lie less than selected number from origin so circles can pass origin");
                Console.WriteLine("4. Create circles with opposite coordinates");
                Console.WriteLine("5. Draw selected number of circles in selected circle");
                Console.WriteLine("6. Print circles with greater area than users number");
                Console.WriteLine("7. Shift circles on the x-axis");
                Console.WriteLine("8. Shift circles on the y-axis");
                Console.WriteLine("9. EXIT");
                int selection;
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    Circle[] circleArray = circle.CreateCirclesWithRandomDiameters();
                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("Enter min diameter:");
                            int minDiameter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter max diameter:");
                            int maxDiameter = int.Parse(Console.ReadLine());
                            circle.PrintSelectedDiameters(circleArray, minDiameter, maxDiameter);
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter min circumference:");
                            int minCicrumference = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter max circumference:");
                            int maxCircumference = int.Parse(Console.ReadLine());
                            circle.PrintSelectedCircumference(circleArray, minCicrumference, maxCircumference);
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter selected distance from origin:");
                            int distanceFromOrigin = int.Parse(Console.ReadLine());
                            circle.ChangeDiameterToOrigin1(circleArray, distanceFromOrigin);
                            Console.ReadLine();
                            break;
                        case 4:
                            circle.oppositeCoordinates(circleArray);
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter number of selected circle:");
                            int selectedCircle = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter hoe many circles do you want to create:");
                            int numberOfCircles = int.Parse(Console.ReadLine());
                            circle.CirclesInCircle(circleArray, selectedCircle, numberOfCircles);
                            Console.ReadLine();
                            break;
                        case 6:
                            circle.CirclesWithGreaterArea(circleArray);
                            Console.ReadLine();
                            break;
                        case 7:
                            circle.ShiftX(circleArray);
                            Console.ReadLine();
                            break;
                        case 8:
                            circle.ShiftY(circleArray);
                            Console.ReadLine();
                            break;
                        case 9:
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Wrong value.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong value.");
                }

            } while (loop);
        }
    }
}










//Ändra så att användaren skriver in siffror i stället för att ha hårdkodade värden som 7, 17, 2... på punkt 1 i denna uppgiften.

