using System;
using System.Collections.Generic;

namespace EventandDelegates.Message
{
    public interface IMessage
    {
        IList<string> SendTo { get; set; }
        string MessageText { get; set; }
        bool Send();
    }
}
