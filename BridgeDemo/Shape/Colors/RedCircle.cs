using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemo.Shape.Colors
{
    public class RedCircle : IColor
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: " + radius + ", x: " + x + ", y: " + y + " ]");
        }
    }
}
