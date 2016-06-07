using HelloWorld.Enums;
using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Utilities
{
    public class StringMessageCollector : MessageCollectorBase
    {
        private EnumMessage _enumMessage = EnumMessage.HelloWorldMessage;
        public string Message { get; set; }

        public StringMessageCollector SetMessage(EnumMessage enumMessage)
        {
            this.Message = enumMessage == EnumMessage.HelloWorldMessage 
                ? ((DescriptionAttribute)typeof(EnumMessage).GetMember(EnumMessage.HelloWorldMessage.ToString())[0].GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description
                : ((DescriptionAttribute)typeof(EnumMessage).GetMember(EnumMessage.GoodbyeWorldMessage.ToString())[0].GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description;

            return this;
        }

        public override string CollectMessage()
        {
            // Mock of collecting message
            this.SetMessage(_enumMessage);

            return Message;
        }
    }
}