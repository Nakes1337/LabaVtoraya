using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    class Rhomb : Figure
    {
        public double FirstDiagonal { get; set; }
        public double SecondDiagonal { get; set; }
        public override double GetArea()
        {
            return 0.5 * FirstDiagonal * SecondDiagonal;
        }
    }
}
