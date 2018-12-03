using System;

namespace Assignment3
{
    class Rec : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area() => Height * Width;
        public double Perimeter() =>  (2 * Height) + (2 * Width);

        override public String ToString() => $"rectangle of sides {Height} x {Width}";
    }
    
}