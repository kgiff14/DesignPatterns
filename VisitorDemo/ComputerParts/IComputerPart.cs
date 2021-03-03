using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.ComputerParts
{
    public interface IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
