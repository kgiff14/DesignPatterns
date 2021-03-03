using System;

namespace MediatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User rob = new User("Rob");
            User jack = new User("Jack");

            rob.SendMessage("Sup dawg. this is the home boy robbie baybee");
            jack.SendMessage("ayyyy wus goin homie");
        }
    }
}
