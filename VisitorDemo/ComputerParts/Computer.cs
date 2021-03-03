using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.ComputerParts
{
    public class Computer : IComputerPart
    {
        public IComputerPart[] parts { get; set; }

        public Computer() => parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor()};

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }
}
