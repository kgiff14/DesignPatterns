using DecoratorDemo.Decorations.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.Decorations
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape shape { get; set; }
        public ShapeDecorator(IShape decoratedShape)
        {
            shape = decoratedShape;
        }
        public virtual void Draw()
        {
            shape.Draw();
        }
    }
}
