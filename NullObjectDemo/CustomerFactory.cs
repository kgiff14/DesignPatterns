using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectDemo
{
    public class CustomerFactory
    {
        public static string[] names = { "rob", "joe", "julie" };

        public static AbstractCustomer GetCustomer(string name)
        {
            for(int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower().Contains(name))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
