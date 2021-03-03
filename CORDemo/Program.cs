using System;

namespace CORDemo
{
    class Program
    {
        private static AbstractLogger getChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger((int)AbstractLogger.Level.ERROR);
            AbstractLogger fileLogger = new FileLogger((int)AbstractLogger.Level.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger((int)AbstractLogger.Level.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
        static void Main(string[] args)
        {
            AbstractLogger loggerchain = getChainOfLoggers();

            loggerchain.LogMessage((int)AbstractLogger.Level.INFO, "This is an information");
            loggerchain.LogMessage((int)AbstractLogger.Level.DEBUG, "This is a debug level information");
            loggerchain.LogMessage((int)AbstractLogger.Level.ERROR, "This is an error information");
        }
    }
}
