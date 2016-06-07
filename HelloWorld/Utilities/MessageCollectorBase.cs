using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Utilities
{
    public abstract class MessageCollectorBase : IMessageCollector
    {
        public abstract string CollectMessage();
    }
}
