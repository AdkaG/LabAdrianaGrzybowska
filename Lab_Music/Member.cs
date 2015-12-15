using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    class Member
    {
        public Instrumenttype Instrument { get; set; }
        public override string ToString()
        {
            return $"Instrumenttype: {Instrument}";
        }
    }
}
