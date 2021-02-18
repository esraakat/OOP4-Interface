using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4_Interface
{
    class FileBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("It has been logged to the filebase");
        }
    }
}
