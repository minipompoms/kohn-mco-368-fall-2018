using System;

namespace Assignment3
{
    public class Triangle
    {
        public double Side { get; set; }
        override public String ToString() => $"Triangle of side {Side}";
    }
}