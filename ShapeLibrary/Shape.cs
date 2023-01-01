using System;

namespace ShapeLibrary
{
    public class Shape
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public virtual double GetArea() => Area;
        public virtual double GetPerimeter() => Perimeter;
        public void Info()
        {
            Console.WriteLine($"Площадь: {GetArea()}");
            Console.WriteLine($"Периметр: {GetPerimeter()}");
        }
    }
}