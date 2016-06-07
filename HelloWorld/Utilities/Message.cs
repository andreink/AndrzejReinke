using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Utilities
{
    public class Message : IMessage
    {
        private readonly IMessageCollector _messageCollector;
        private readonly IWriter _textWriter;

        public Message(IMessageCollector messageCollector, IWriter textWriter)
        {
            if (messageCollector == null) 
            {
                throw new ArgumentNullException("Message collector");
            }
            _messageCollector = messageCollector;

            if (textWriter == null) 
            {
                throw new ArgumentNullException("Text writer"); 
            } 
            _textWriter = textWriter;
        }
        public void Expose()
        {
            string message = _messageCollector.CollectMessage();
            _textWriter.Write(message);
        }
    }
}