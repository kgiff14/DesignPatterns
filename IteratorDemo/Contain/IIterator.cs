using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDemo.Contain
{
    public interface IIterator
    {
        public bool HasNext();
        public Object Next();
    }
}
