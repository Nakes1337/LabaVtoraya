using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class Circle : Figure
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }
    }
}
