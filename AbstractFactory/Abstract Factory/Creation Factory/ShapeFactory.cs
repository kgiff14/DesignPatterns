using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Abstract_Factory.Creation_Factory.Shapes;

namespace AbstractFactory.Abstract_Factory.Creation_Factory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if(shapeType is null)
            {
                return null;
            }
            else if (shapeType.ToLower().Contains("square"))
            {
                return new Square();
            }
            else if (shapeType.ToLower().Contains("rectangle"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
