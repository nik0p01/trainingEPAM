using System;

namespace Countdown
{
    public class Listener2
    {
        public Listener2(CountdownMessage message)
        {
            message.SendMessage += SentMessageToListener2;
        }
        private void SentMessageToListener2(object sender, MessageEventArgs eventArgs)
        {
            Console.WriteLine($"Message {eventArgs.Message} sendt to Listener2");
        }

        public void Unregister(CountdownMessage message)
        {
            message.SendMessage -= SentMessageToListener2;
        }
    }
}