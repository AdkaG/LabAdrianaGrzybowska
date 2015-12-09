using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    class School
    {
        string name;
        int numberOfClass;
        double area;
        ClassRoom classRoom;
        Teacher teacher;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetNumberOfClass()
        {
            return numberOfClass;
        }
        public void SetNumberOfClass(int numberOfClass)
        {
            this.numberOfClass = numberOfClass;
        }
        public double GetArea()
        {
            return area;
        }
        public void SetArea(double area)
        {
            this.area = area;
        }
        public ClassRoom GetClassRoom()
        {
            return classRoom;
        }
        public void SetClassRoom(ClassRoom classRoom)
        {
            this.classRoom = classRoom;
        }
        public Teacher GetTeacher()
        {
            return teacher;
        }
        public void SetTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }

        public double ClassRoomsArea(params ClassRoom[] array)
        {
            double roomsArea = 0;
            for (int i = 0; i < array.Length; i++)
            {
                roomsArea += array[i].GetArea();
            }
            return roomsArea;
        }
        public double AverageTeachersAge(params Teacher[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i].GetAge();
            }
            double averageAge = Math.Round((sum / array.Length), 0);
            return averageAge;
        }
        public double AverageTeachersSalary(params Teacher[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i].GetSalary();
            }
            double averageSalary = Math.Round((sum / array.Length), 2);
            return averageSalary;
        }

    }
}
