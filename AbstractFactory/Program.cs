using AbstractFactory.Abstract_Factory.Creation_Factory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract_Factory.AbstractFactory shapeFactory = FactoryProducer.GetFactory(false);
            IShape shape1 = shapeFactory.GetShape("square");
            shape1.DrawShape();
            IShape shape2 = shapeFactory.GetShape("Rectangle");
            shape2.DrawShape();

            Abstract_Factory.AbstractFactory roundedShapeFactory = FactoryProducer.GetFactory(true);
            IShape shape3 = roundedShapeFactory.GetShape("square");
            shape3.DrawShape();
            IShape shape4 = roundedShapeFactory.GetShape("rectangle");
            shape4.DrawShape();
        }
    }
}
