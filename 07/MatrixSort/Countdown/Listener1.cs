using System;

namespace Countdown
{
    public class Listener1
    {
        public Listener1(CountdownMessage message)
        {
            message.SendMessage += SentMessageToListener1;
        }
        private void SentMessageToListener1(object sender, MessageEventArgs eventArgs)
        {
            Console.WriteLine($"Message {eventArgs.Message} sendt to Listener1");
        }

        public void Unregister(CountdownMessage message)
        {
            message.SendMessage -= SentMessageToListener1;
        }
    }
}
