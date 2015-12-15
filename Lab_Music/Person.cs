using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"FirstName: {FirstName}, LastName: {LastName}";
    }
}
