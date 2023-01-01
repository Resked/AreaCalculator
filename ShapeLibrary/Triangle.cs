using System;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

            if (SideA * SideA + SideB * SideB == SideC * SideC)
            {
                Console.WriteLine("Данный треугольник прямоугольный!");
            }
        }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            Area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = SideA + SideB + SideC;
            return Perimeter;
        }

    }
}