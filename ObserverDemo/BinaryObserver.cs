﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary string: " + Convert.ToString(subject.GetState(), 2));
        }
    }
}
