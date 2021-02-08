using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.Decorations.Shapes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
