using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDemo.Shape.Colors
{
    public class GreenCircle : IColor
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: " + radius + ", x: " + x + ", y: " + y + " ]");
        }
    }
}
