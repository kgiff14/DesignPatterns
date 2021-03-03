using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDemo
{
    public class Originator
    {
        private string state { get; set; }

        public void SetState(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }

        public Memento SaveStateToMemento()
        {
            return new Memento(state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            state = memento.GetState();
        }
    }
}
