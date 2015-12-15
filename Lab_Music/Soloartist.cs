using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Music
{
    class Soloartist
    {
        public Member Member { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, Member: {Member}";
        }
    }
}
