using System;
using VisitorDemo.ComputerParts;

namespace VisitorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
