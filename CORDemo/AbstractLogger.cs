using System;
using System.Collections.Generic;
using System.Text;

namespace CORDemo
{
    public abstract partial class AbstractLogger
    {
        public enum Level
        {
            INFO,
            DEBUG,
            ERROR
        }

        protected int level { get; set; }

        protected AbstractLogger nextLogger { get; set; }

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if(this.level <= level)
            {
                Write(message);
            }
            if(nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }

        protected abstract void Write(string message);
    }
}
