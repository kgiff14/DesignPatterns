using Factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("circle");
            shape1.DrawShape();

            IShape shape2 = shapeFactory.GetShape("square");
            shape2.DrawShape();

            IShape shape3 = shapeFactory.GetShape("diamond");
            shape3.DrawShape();
        }
    }
}
