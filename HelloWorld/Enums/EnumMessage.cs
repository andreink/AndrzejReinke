using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Enums
{
    public enum EnumMessage
    {
        [Description("Hello World!")]
        HelloWorldMessage,

        [Description("Goodbye World!")]
        GoodbyeWorldMessage,
    }
}