using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex string: " + Convert.ToString(subject.GetState(), 16));
        }
    }
}
