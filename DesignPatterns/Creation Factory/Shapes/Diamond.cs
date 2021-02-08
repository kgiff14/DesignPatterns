using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Creation_Factory
{
    public class Diamond : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("We drew a Diamond");
        }
    }
}
