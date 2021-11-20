using System;

namespace DZ6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1, 1, 10);
            Console.WriteLine(circle);
            Console.WriteLine($"Площадь {circle.AreaOfACircle()}");
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine(rectangle);
            Console.WriteLine($"Площадь {rectangle.AreaOfARectangle()}");
        }
    }
}
