using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LabaVtoraya
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea() => Width * Height;
    }
}
