using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class RegularDecagon : Figure
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return 2.5 * Math.Pow(Side, 2) / Math.Tan(18);
        }
    }
}
