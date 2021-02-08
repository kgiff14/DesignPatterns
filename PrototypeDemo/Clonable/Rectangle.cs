using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo.Clonable
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }

        public override void draw()
        {
            Console.WriteLine("Drew a Rectangle");
        }
    }
}
