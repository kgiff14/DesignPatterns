using System;
using System.Collections.Generic;
using System.Text;
using VisitorDemo.ComputerParts;

namespace VisitorDemo
{
    public interface IComputerPartVisitor
    {
        public void Visit(Computer computer);
        public void Visit(Mouse mouse);
        public void Visit(Keyboard keyboard);
        public void Visit(Monitor monitor);

    }
}
