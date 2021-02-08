using PrototypeDemo.Clonable;
using System;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.LoadCache();

            Shape ClonedShape1 = ShapeCache.GetShape("1");
            Console.WriteLine("Shape: " + ClonedShape1.GetType());

            Shape ClonedShape2 = ShapeCache.GetShape("2");
            Console.WriteLine("Shape: " + ClonedShape2.GetType());

            Shape ClonedShape3 = ShapeCache.GetShape("3");
            Console.WriteLine("Shape: " + ClonedShape3.GetType());
        }
    }
}
