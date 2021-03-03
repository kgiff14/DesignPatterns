using System;

namespace MementoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            originator.SetState("mine iron");
            originator.SetState("mine more iron");
            //autosave 1
            caretaker.Add(originator.SaveStateToMemento());

            originator.SetState("found some silver ayyyy yooo");
            //autosave 2
            caretaker.Add(originator.SaveStateToMemento());

            originator.SetState("died to a monster");
            //autosave 3
            caretaker.Add(originator.SaveStateToMemento());

            //load up autosave 1
            originator.GetStateFromMemento(caretaker.Get(0));
            Console.WriteLine("First autosave: " + originator.GetState());

            //load up autosave 2
            originator.GetStateFromMemento(caretaker.Get(1));
            Console.WriteLine("Second autosave: " + originator.GetState());
        }
    }
}
