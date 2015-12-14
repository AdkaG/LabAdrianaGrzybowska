using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3
{
    public class Point
    {
        int x;
        int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


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

        public Point()
        {
            
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"pointX: {GetX()}, pointY: {GetY()}";
    }
}
