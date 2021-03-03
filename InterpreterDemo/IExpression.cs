using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDemo
{
    public interface IExpression
    {
        public bool Interpret(string context);
    }
}
