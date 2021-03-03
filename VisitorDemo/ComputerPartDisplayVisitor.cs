using System;
using System.Collections.Generic;
using System.Text;
using VisitorDemo.ComputerParts;

namespace VisitorDemo
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer) => Console.WriteLine("Displaying computer");

        public void Visit(Mouse mouse) => Console.WriteLine("Displaying Mouse");

        public void Visit(Keyboard keyboard) => Console.WriteLine("Displaying Keyboard");

        public void Visit(Monitor monitor) => Console.WriteLine("Displaying Monitor");
    }
}
