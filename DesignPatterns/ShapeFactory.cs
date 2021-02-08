using Factory.Creation_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if(shapeType is null)
            {
                return null;
            }
            else if (shapeType.ToLower().Contains("circle"))
            {
                return new Circle();
            }
            else if (shapeType.ToLower().Contains("diamond"))
            {
                return new Diamond();
            }
            else if (shapeType.ToLower().Contains("square"))
            {
                return new Square();
            }
            return null;
        }
    }
}
