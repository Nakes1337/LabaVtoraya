using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class Square : Figure
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return Math.Pow(Side, 2);
        }
    }
}
