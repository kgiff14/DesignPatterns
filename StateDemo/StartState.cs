using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo
{
    public class StartState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("We are in a starting state");
            context.SetState(this);
        }

        public new string ToString() => "Start State";
    }
}
