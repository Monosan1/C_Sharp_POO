using System;
using System.Collections.Generic;
using System.Text;

namespace EstaticMembers
    {
    class Calc
        {
        public double Pi = 3.14;

        public double Circunferencia(double r)
            {
            return 2 * Pi * r;
            }
        public double Volume(double r)
            {
            return 4 * Pi * Math.Pow(r, 3) / 3;
            }
        }
    }
