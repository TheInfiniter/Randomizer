using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    struct Spin
    {
        /// <summary>
        /// Координата Х центра спина.
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Координата Y центра спина.
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// Знак спина.
        /// </summary>
        public int Sign { get; set; }

        public Spin(double x, double y)
        {
            X = x;
            Y = y;
            Sign = 0;
        }
    }
}
