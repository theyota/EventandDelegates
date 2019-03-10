using System;
namespace EventandDelegates.Logs
{
    public class Log
    {
        public DateTime TimeStamp { get { return DateTime.Now; } }

        public string Type { get; set; }

        public string Severity { get; set; }

        public string Component { get; set; }

        public string Message { get; set; }

        public string OutPutMessage { get { return $"{TimeStamp}\t{Severity}\t{Type}\t{Component}\t{Message}"; } }

    }
}
