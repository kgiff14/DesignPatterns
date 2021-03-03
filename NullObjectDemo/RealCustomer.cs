using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDemo
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name) => this.name = name;

        public override string GetName() => name;

        public override bool IsNil() => false;
    }
}
