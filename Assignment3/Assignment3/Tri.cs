using System;

namespace Assignment3
{
    public class Tri : Shape
    {
        public double Side {get; set;}
        public double Area() => (((Math.Sqrt(3)) / 4) *  Side * Side); 
        public double Perimeter() => 3 * Side;
       
        override public String ToString() => $"Triangle of side {Side}";
    }
}