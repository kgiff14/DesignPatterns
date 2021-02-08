using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo.ItemClasses.ItemConcreteItems
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float Price()
        {
            return 4.75f;
        }
    }
}
