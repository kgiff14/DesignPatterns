using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo.ItemClasses.ItemConcreteItems
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veggie Burger";
        }

        public override float Price()
        {
            return 5.50f;
        }
    }
}
