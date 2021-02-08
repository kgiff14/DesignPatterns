using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class SingleObject
    {
        private static SingleObject singleObject = new SingleObject();

        private SingleObject() { }

        public static SingleObject GetInstance()
        {
            return singleObject;
        }

        public void ShowMessage()
        {
            Console.WriteLine("You just used a singleton! Good job!");
        }
    }
}
