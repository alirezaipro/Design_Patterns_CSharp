using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_Decorator
{
    public class SendSmsDecorator:SendSms
    {
        private readonly SendSms _sendSms;

        public SendSmsDecorator(SendSms sendSms)
        {
            _sendSms = sendSms;
        }

        public void Send()
        {
            _sendSms.Send();
            Console.WriteLine("SendSmsDecorator.Send");
        }
    }
}
