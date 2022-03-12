using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class RegularPentagon : Figure
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return 1.25 * Math.Pow(Side, 2) / Math.Tan(36);
        }
    }
}
