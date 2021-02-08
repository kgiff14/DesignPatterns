using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo.ItemClasses.ItemConcreteItems
{
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 2.25f;
        }
    }
}
