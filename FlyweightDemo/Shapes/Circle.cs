using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDemo.Shapes
{
    public class Circle : IShape
    {
        private string color { get; set; }
        private int x { get; set; }
        private int y { get; set; }
        private int radius { get; set; }

        public Circle(string color)
        {
            this.color = color;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color: " + color + ", x: " + x + ", y: " + y + ", radius: " + radius + "]");
        }
    }
}
