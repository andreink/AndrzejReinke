using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Utilities
{
    public class LogWriter : IWriter
    {
        private readonly ILogger _logger;
        private readonly IWriter _textWriter;

        public LogWriter(ILogger logger, IWriter textWriter)
        {
            if (logger == null) 
            { 
                throw new ArgumentNullException("Logger");
            }
            _logger = logger;

            if (textWriter == null)
            {
                throw new ArgumentNullException("TextWriter");
            } 
            _textWriter = textWriter;
        }

        public void Write(string text)
        {
            _logger.Log();
            _textWriter.Write(text);
        }
    }
}