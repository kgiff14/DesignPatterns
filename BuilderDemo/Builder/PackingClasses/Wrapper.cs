using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo.PackingClasses
{
    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
