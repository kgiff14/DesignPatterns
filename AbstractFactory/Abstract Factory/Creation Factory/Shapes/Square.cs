using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Abstract_Factory.Creation_Factory.Shapes
{
    public class Square : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("We drew a regular Square");
        }
    }
}
