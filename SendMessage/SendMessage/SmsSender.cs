using System;
using System.Collections.Generic;
using System.Text;

namespace SendMessage
{
    internal class SmsSender: MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Send message by sms");
        }

    }
}
