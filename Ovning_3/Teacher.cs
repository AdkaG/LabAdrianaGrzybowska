using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    class Teacher
    {
        int age;
        string name;
        double salary;

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public double GetSalary()
        {
            return salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
    }
}
