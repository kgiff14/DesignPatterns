using AbstractFactory.Abstract_Factory.Creation_Factory.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstract_Factory.Creation_Factory
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if(shapeType is null)
            {
                return null;
            }
            else if (shapeType.ToLower().Contains("square"))
            {
                return new RoundedSquare();
            }
            else if (shapeType.ToLower().Contains("rectangle"))
            {
                return new RoundedRectangle();
            }
            return null;
        }
    }
}
