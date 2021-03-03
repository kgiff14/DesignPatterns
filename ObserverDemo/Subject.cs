using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDemo
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state { get; set; }

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
