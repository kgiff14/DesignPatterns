using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.ComputerParts
{
    public class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor) => computerPartVisitor.Visit(this);
    }
}
