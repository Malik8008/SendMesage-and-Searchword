using System;

namespace SendMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Send message by email");
            Console.WriteLine("2.Send message by sms");
            Console.WriteLine("0.Exit");

            EmailSender email = new EmailSender();  
            SmsSender sms = new SmsSender();
            int num=Convert.ToInt32(Console.ReadLine());    

            switch (num)
            {
                case 1:
                    email.SendMessage();
                    return;
                case 2:
                    sms.SendMessage();
                    return;
                case 0:
                    Console.WriteLine("Exit");
                    return;
            }

        }
    }
}
