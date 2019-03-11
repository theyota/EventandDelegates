using System;
using System.Threading;
using System.Collections.Generic;
using EventandDelegates.Logs;

namespace EventandDelegates.Message
{
    public class TextMessage : IMessage

    {
        public IList<string> SendTo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MessageText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Send()
        {
            Console.WriteLine("Text Message Service: sending text message...");
            Thread.Sleep(3000);
            OnTexted(new Log() { Type = "5", Component = "TextMessage", Severity = "medium", Message = "Text sent successfully" });
            return true;
        }

        public event EventHandler<LogEventArgs> Texted;

        public virtual void OnTexted(Log log)
        {
            Texted?.Invoke(this, new LogEventArgs() { Log = log });
        }


    }
}
