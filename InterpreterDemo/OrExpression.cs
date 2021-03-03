using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDemo
{
    public class OrExpression : IExpression
    {
        private IExpression expression1 { get; set; } = null;
        private IExpression expression2 { get; set; } = null;

        public OrExpression(IExpression expression1, IExpression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        public bool Interpret(string context)
        {
            return expression1.Interpret(context) || expression2.Interpret(context);
        }
    }
}
