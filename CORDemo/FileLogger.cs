using System;
using System.Collections.Generic;
using System.Text;

namespace CORDemo
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }
        protected override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
