using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Utilities
{
    public class Logger : ILogger
    {
        public void Log()
        {
            // Logging information about process.
        }

        public void Log(IList<Exception> exceptions)
        {
            foreach (var exception in exceptions)
            {
                Console.WriteLine(exception);
            }
        }
    }
}