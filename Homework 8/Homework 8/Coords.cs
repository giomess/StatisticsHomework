using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Coords
    {
        public double X;
        public double Y;

        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X.ToString() + " - " + Y.ToString();
        }
    }
}
