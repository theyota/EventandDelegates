using System;
using EventandDelegates.Logs;
using EventandDelegates.Message;
namespace EventandDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            LogEvent logEvent = new LogEvent();
            EmailMessage emailMessage = new EmailMessage();
            TextMessage textMessage = new TextMessage();


            emailMessage.Emailed += logEvent.OnMailed;
            textMessage.Texted += logEvent.OnTexted;

            emailMessage.Send();
            textMessage.Send();
        }
    }
}
