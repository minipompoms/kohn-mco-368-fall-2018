using System;

namespace Assignment3
{
    class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override String ToString() => $"rectangle of sides {Height} x {Width}";

    }
}