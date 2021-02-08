using DecoratorDemo.Decorations;
using DecoratorDemo.Decorations.Shapes;
using System;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();

            IShape rectangle = new Rectangle();

            IShape redCircle = new RedShapeDecorator(new Circle());

            IShape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle with red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle with normal border");
            rectangle.Draw();

            Console.WriteLine("\nRectangle with red border");
            redRectangle.Draw();
        }
    }
}
