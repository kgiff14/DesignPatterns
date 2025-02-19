﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDemo
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        public void Play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        }
    }
}
