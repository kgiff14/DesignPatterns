using BridgeDemo.Shape.Colors;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemo.Shape
{
    public class Circle : Shape
    {
        private int x { get; set; }
        private int y { get; set; }
        private int radius { get; set; }

        public Circle(int x, int y, int radius, IColor color) : base(color)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public override void Draw()
        {
            color.DrawCircle(radius, x, y);
        }
    }
}
