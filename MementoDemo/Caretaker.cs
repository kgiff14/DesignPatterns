using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDemo
{
    public class Caretaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento memento)
        {
            mementoList.Add(memento);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }
    }
}
