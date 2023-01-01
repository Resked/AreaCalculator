using System;
using ShapeLibrary;


namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны: a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Shape triangle = new Triangle(a, b, c);
            triangle.Info();

            Console.Write("\nВведите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Shape сircle = new Circle(r);
            сircle.Info();
        }
    }
}
