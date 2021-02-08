using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject single = SingleObject.GetInstance();

            single.ShowMessage();
        }
    }
}
