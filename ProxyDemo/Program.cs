using System;

namespace ProxyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_154gb.jpg");

            image.Display();
            Console.WriteLine("");

            image.Display();
        }
    }
}
