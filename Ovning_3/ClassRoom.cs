using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    class ClassRoom
    {
        string name;
        double area;
        int numberOfPlaces;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public double GetArea()
        {
            return area;
        }
        public void SetArea(double area)
        {
            this.area = area;
        }
        public int GetNumberOfPlaces()
        {
            return numberOfPlaces;
        }
        public void SetNumberOfPlaces(int numberOfPlaces)
        {
            this.numberOfPlaces = numberOfPlaces;
        }
    }
}
