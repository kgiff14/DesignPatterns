using AbstractFactory.Abstract_Factory.Creation_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstract_Factory
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);
    }
}
