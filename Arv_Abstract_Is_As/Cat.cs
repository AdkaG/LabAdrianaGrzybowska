using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv_Abstract_Is_As
{
    class Cat : Feline
    {
        public override string GetSound()
        {
            return "Miau";
        }

        public override int GetMaximumSpeed()
        {
            return 120;
        }
    }
}
