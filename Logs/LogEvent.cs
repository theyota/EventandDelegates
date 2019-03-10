using System;
namespace EventandDelegates.Logs
{
    public class LogEvent
    {
        public virtual void OnMailed(object source, LogEventArgs e)
        {
            Console.WriteLine(e.Log.OutPutMessage);
        }
        public virtual void OnTexted(object source, LogEventArgs e)
        {
            Console.WriteLine(e.Log.OutPutMessage);
        }
    }
}
