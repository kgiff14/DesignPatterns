using BridgeDemo.Shape;
using BridgeDemo.Shape.Colors;
using System;

namespace BridgeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape.Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape.Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
