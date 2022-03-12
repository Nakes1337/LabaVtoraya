using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class Parallelogram : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Base * Height;
        }
    }
}
