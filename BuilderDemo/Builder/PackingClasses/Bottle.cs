using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo.PackingClasses
{
    public class Bottle : IPacking
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
