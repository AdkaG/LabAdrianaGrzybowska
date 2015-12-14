using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Abstract_Is_As
{
    abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        abstract public string GetSound();
        
    }
}
