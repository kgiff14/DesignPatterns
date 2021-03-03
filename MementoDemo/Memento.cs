using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDemo
{
    public class Memento
    {
        private string state { get; set; }
        
        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}
