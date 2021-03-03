using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDemo.Contain
{
    public class NameRepository : IContainer
    {
        public static string[] Names = { "Robert", "John", "Julie", "Lora" };

        public IIterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            int index { get; set; }
            public bool HasNext()
            {
                if(index < Names.Length)
                {
                    return true;
                }
                return false;
            }

            public object Next()
            {
                if (this.HasNext())
                {
                    return Names[index++];
                }
                return null;
            }
        }
    }
}
