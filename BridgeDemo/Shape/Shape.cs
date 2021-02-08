using BridgeDemo.Shape.Colors;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemo.Shape
{
    public abstract class Shape
    {
        protected IColor color { get; set; }

        protected Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Draw();
    }
}
