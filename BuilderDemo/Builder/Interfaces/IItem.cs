using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDemo
{
    public interface IItem
    {
        public string Name();
        public IPacking Packing();
        public float Price();
    }
}
