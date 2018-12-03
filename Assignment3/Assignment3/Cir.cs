using System;

namespace Assignment3
{
    class Cir : Shape
    {
        public double Radius { get; set; }
        private readonly double PI = 3.14159265;
        public double Area() => PI * Radius * Radius;
        public double Perimeter() => 2 * PI * Radius;
        override public String ToString() => $"Circle of radius {this.Radius}";
    }
}