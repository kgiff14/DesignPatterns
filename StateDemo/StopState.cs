using System;
using System.Collections.Generic;
using System.Text;

namespace StateDemo
{
    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("We are in a stop state.");
            context.SetState(this);
        }

        public new string ToString() => "Stop State";
    }
}
