using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Creation_Factory
{
    public class Circle : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("We drew a Circle");
        }
    }
}
