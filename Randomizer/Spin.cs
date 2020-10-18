using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    struct Spin
    {
        public double X { get; set; }
        public double Y { get; set; }
        public int Sign { get; set; }

        public Spin(double x, double y, int sign)
        {
            X = x;
            Y = y;
            Sign = sign;
        }
    }
}
