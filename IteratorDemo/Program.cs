using IteratorDemo.Contain;
using System;

namespace IteratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository nameRepository = new NameRepository();
            IIterator iterator = nameRepository.GetIterator();

            while (iterator.HasNext())
            {
                string name = (string)iterator.Next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
