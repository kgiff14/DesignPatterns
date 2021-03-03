using System;

namespace InterpreterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpression isMale = GetMaleExpression();
            IExpression isMarried = GetMarriedExpression();

            Console.WriteLine("Is rob male?" + isMale.Interpret("rob"));
            Console.WriteLine("Is Anna married?" + isMarried.Interpret("Anna married"));
            Console.WriteLine("Is jill married?" + isMarried.Interpret("jill married"));
        }
        public static IExpression GetMaleExpression()
        {
            IExpression rob = new TerminalExpression("rob");
            IExpression jack = new TerminalExpression("jack");
            return new OrExpression(rob, jack);
        }
        
        public static IExpression GetMarriedExpression()
        {
            IExpression jill = new TerminalExpression("jill");
            IExpression married = new TerminalExpression("married");
            return new AndExpression(jill, married);
        }
    }
}
