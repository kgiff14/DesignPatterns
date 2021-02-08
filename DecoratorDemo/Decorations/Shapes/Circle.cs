using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDemo.Decorations.Shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
