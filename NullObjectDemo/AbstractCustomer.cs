using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDemo
{
    public abstract class AbstractCustomer
    {
        protected string name;
        public abstract bool IsNil();
        public abstract string GetName();
    }
}
