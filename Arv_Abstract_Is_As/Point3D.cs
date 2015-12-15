using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ovning_3;


namespace Arv_Abstract_Is_As
{
    class Point3D : Point
    {
        int z;
        public int Z { get; set; }

        public Point3D()
        {

        }
        public Point3D(int z)
        {
            Z = z;
        }
        public Point3D(int x, int y, int z):base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Z: {Z}";
        }
    }
}
