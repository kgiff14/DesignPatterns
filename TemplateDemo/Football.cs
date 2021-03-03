using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDemo
{
    public class Football : Game
    {
        public override void EndPlay() => Console.WriteLine("Football game has finished");

        public override void Initialize() => Console.WriteLine("Football initialized. start game");

        public override void StartPlay() => Console.WriteLine("Football game has started.");
    }
}
