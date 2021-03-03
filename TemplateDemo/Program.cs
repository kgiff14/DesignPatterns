using System;

namespace TemplateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();

            game = new Football();
            game.Play();
        }
    }
}
