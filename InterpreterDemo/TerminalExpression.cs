using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDemo
{
    public class TerminalExpression : IExpression
    {
        private string data { get; set; }

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool Interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }
}
