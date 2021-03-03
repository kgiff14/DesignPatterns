using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDemo.Contain
{
    public interface IContainer
    {
        public IIterator GetIterator();
    }
}
