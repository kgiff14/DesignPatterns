using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo.Clonable
{
    public class Circle : Shape
    {
        public Circle()
        {
            type = "Circle";
        }
        public override void draw()
        {
            Console.WriteLine("Drew a Circle");
        }
    }
}
