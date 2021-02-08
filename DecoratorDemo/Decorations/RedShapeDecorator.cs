using DecoratorDemo.Decorations.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.Decorations
{
    public class RedShapeDecorator : ShapeDecorator
    {
        private IShape Shape { get; set; }
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
            Shape = decoratedShape;
        }

        public override void Draw()
        {
            Shape.Draw();
            setRedBorder(Shape);
        }

        private void setRedBorder(IShape shape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
