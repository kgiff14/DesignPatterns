using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDemo.Shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
