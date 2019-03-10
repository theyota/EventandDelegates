using System;
namespace EventandDelegates.Logs
{
    public class LogEventArgs:EventArgs
    {
        public Log Log { get; set; }
    }
}
