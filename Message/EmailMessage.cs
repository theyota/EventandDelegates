using System;
using System.Threading;
using System.Collections.Generic;
using EventandDelegates.Logs;

namespace EventandDelegates.Message
{
    public class EmailMessage : IMessage
    {


        public IList<string> SendTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MessageText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Send()
        {
            Console.WriteLine("Email Message Service: sending email...");
            Thread.Sleep(3000);
            OnTexted(new Log() {Type = "5",Component ="EmailMessage", Severity ="medium", Message = "Email sent successfully" });
            return true;
        }

        public event EventHandler<LogEventArgs> Emailed;

        protected virtual void OnTexted(Log log)
        {
            Emailed?.Invoke(this, new LogEventArgs() { Log = log });
        }

    }
}
