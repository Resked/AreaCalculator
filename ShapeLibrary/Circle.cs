using System;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
            return Perimeter;
        }
    }
}