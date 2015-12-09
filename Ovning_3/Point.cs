using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    class Point
    {
        int x;
        int y;
        public int GetX()
        {
            return x;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public override string ToString() => $"pointX: {GetX()}, pointY: {GetY()}";
    }
}
