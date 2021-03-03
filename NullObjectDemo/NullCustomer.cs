using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDemo
{
    public class NullCustomer : AbstractCustomer
    {
        public override string GetName() => "N/A";

        public override bool IsNil() => true;
    }
}
