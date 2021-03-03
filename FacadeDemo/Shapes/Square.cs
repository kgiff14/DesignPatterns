using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Square");
        }
    }
}
