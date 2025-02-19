﻿using BuilderDemo.PackingClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo.ItemClasses
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }
}
