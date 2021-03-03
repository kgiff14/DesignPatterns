using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal string: " + Convert.ToString(subject.GetState(), 8));
        }
    }
}
