using System;
using System.Threading;

namespace Countdown
{
    public class CountdownMessage
    {
        public event EventHandler<MessageEventArgs> SendMessage = delegate { };

        protected virtual void NewMessage(MessageEventArgs e)
        {
            SendMessage?.Invoke(this, e);
        }
        public void SendNewMessageAfterSleep(string message, int sleepSec)
        {
            Thread.Sleep(sleepSec * 100);
            NewMessage(new MessageEventArgs(message));
        }

    }
}
