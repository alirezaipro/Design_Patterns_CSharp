using _01_01_Decorator;

SendSms sendSms = new SendSms();
sendSms.Send();


Console.WriteLine("--------------------------------");


SendSmsDecorator sendSmsDecorator = new SendSmsDecorator(sendSms);
sendSmsDecorator.Send();