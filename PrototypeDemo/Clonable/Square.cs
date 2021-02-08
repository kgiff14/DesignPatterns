using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo.Clonable
{
    public class Square : Shape
    {
        public Square()
        {
            type = "Square";
        }
        public override void draw()
        {
            Console.WriteLine("Drew a Square");
        }
    }
}
