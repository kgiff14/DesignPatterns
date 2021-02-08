using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Abstract_Factory;
using AbstractFactory.Abstract_Factory.Creation_Factory;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static Abstract_Factory.AbstractFactory GetFactory(bool rounded)
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
