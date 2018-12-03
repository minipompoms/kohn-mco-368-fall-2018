using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            version1();
            version2();

            Console.ReadLine();
        }

        private static void version1()
        {
            Circle circle = new Circle();
            circle.Radius = 1.0;

            Square square = new Square();
            square.Side = 1.0;

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 1.0;
            rectangle.Width = 2.0;
            
            Triangle triangle = new Triangle();
            triangle.Side = 3.0;
                 
            Geometry geometry = new Geometry();
            Console.WriteLine($"geometry of {circle}, {square}, and {rectangle}");     
            Console.WriteLine($"Area of a circle of radius {circle.Radius} is {geometry.Area(circle)}");
            Console.WriteLine($"Perimeter of a circle of radius {circle.Radius} is {geometry.Perimeter(circle)}");

            Console.WriteLine($"Area of a square of side {square.Side} is {geometry.Area(square)}");
            Console.WriteLine($"Perimeter of a square of side {square.Side} is {geometry.Perimeter(square)}");

            Console.WriteLine(
                $"Area of a rectangle {rectangle.Height} x {rectangle.Width} is {geometry.Area(rectangle)}");
            Console.WriteLine(
                $"Perimeter of a rectangle {rectangle.Height} x {rectangle.Width} is {geometry.Perimeter(rectangle)}");

            Console.WriteLine($"Area of a triangle of side {triangle.Side} is {geometry.Area(triangle)}");
            Console.WriteLine($"Perimeter of a triangle of side {triangle.Side} is {geometry.Perimeter(triangle)}");

        }

        private static void version2()
        {
            Cir circle = new Cir();
            circle.Radius = 1.0;

            Squ square = new Squ();
            square.Side = 1.0;

            Rec rectangle = new Rec();
            rectangle.Height = 1.0;
            rectangle.Width = 2.0;
            
            Tri triangle = new Tri();
            triangle.Side = 3.0;

            Console.WriteLine($"geometry of {circle}, {square}, and {rectangle}");
            Console.WriteLine($"Area of a circle of radius {circle.Radius} is {circle.Area()}");
            Console.WriteLine($"Perimeter of a circle of radius {circle.Radius} is {circle.Perimeter()}");

            Console.WriteLine($"Area of a square of side {square.Side} is {square.Area()}");
            Console.WriteLine($"Perimeter of a square of side {square.Side} is {square.Perimeter()}");

            Console.WriteLine($"Area of a rectangle {rectangle.Height} x {rectangle.Width} is {rectangle.Area()}");
            Console.WriteLine($"Perimeter of a rectangle {rectangle.Height} x {rectangle.Width} is {rectangle.Perimeter()}");

            Console.WriteLine($"Area of a triangle of side {triangle.Side} is {triangle.Area()}");
            Console.WriteLine($"Perimeter of a triangle of side {triangle.Side} is {triangle.Perimeter()}");


        }
    }
}