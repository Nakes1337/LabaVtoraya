using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
