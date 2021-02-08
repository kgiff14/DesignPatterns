using PrototypeDemo.Clonable;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    public class ShapeCache
    {
        private static Hashtable hashtable = new Hashtable();

        public static Shape GetShape(string shapeId)
        {
            Shape cachedShape = (Shape)hashtable[shapeId];
            return (Shape)cachedShape.Clone();
        }

        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.SetId("1");
            hashtable.Add(circle.GetId(), circle);

            Square square = new Square();
            square.SetId("2");
            hashtable.Add(square.GetId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("3");
            hashtable.Add(rectangle.GetId(), rectangle);
        }
    }
}
