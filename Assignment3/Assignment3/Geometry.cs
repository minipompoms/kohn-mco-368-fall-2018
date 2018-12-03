using System;

namespace Assignment3
{
    class Geometry
    {
        public readonly double Pi = 3.14159265;
       
        public double Perimeter(Object shape)
        {
            if (shape is Circle)
            {
                Circle cir = (Circle)shape;
                return 2 * Pi * cir.Radius;
            }
            else if (shape is Square)
            {
                Square squ = (Square)shape;
                return 4 * squ.Side;
            }
            else if (shape is Rectangle)
            {
                Rectangle rec = (Rectangle)shape;
                return (2 * rec.Height) + (2 * rec.Width);
            }
            else if (shape is Triangle)
            {
                Triangle tri = (Triangle) shape;
                return 3 * tri.Side;
            }
            throw new Exception("No such shape");  
        }
        
        public double Area(Object shape)
        {
            if (shape is Circle)
            {
                Circle cir = (Circle)shape;
                return Pi * cir.Radius * cir.Radius;
            }
            else if (shape is Square)
            {
                Square squ = (Square)shape;
                return squ.Side * squ.Side;
            }
            else if (shape is Rectangle)
            {
                Rectangle rec = (Rectangle)shape;
                return rec.Height * rec.Width;
            }
            else if (shape is Triangle)
            {
                Triangle tri = (Triangle) shape;
                return (((Math.Sqrt(3)) / 4) *  tri.Side * tri.Side); 
            }
            throw new Exception("No such shape");    
        }
    }

}