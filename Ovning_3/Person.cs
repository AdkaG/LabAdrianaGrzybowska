using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    class Person
    {
        string name;
        //public string GetName()
        //{
        //    return name;
        //}
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
