using System;
using System.Collections.Generic;
using System.Text;

namespace LabaVtoraya
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public abstract double GetArea();
    }
}
