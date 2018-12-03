using System;

namespace Assignment3
{
    class Squ : Shape
    {
        public double Side {get; set;}
        public double Area() => Side * Side;
        public double Perimeter() => 4 * Side;
       
        override public String ToString() => $"Square of side {Side}";
    }
}