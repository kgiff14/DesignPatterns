using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDemo
{
    public class Cricket : Game
    {
        public override void EndPlay() => Console.WriteLine("Cricket game has finished");

        public override void Initialize() => Console.WriteLine("Cricket initialized. start game");

        public override void StartPlay() => Console.WriteLine("Cricket game has started.");
    }
}
