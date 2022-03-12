using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class Trapezoid : Figure
    {
        public double FirstBase{ get; set; }
        public double SecondBase { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return 0.5 * (FirstBase + SecondBase) * Height;
        }
    }
}
