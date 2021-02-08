using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo.ItemClasses.ItemConcreteItems
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 8.65f;
        }
    }
}
