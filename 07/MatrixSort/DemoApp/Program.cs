using Countdown;
using System;

namespace DemoApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter time for waiting in sec");
            if (!int.TryParse(Console.ReadLine(), out int time))
            {
                Console.WriteLine("It is not a number");
                return;
            }
            var countdownMessage = new CountdownMessage();

            Listener1 listener1 = new Listener1(countdownMessage);
            Listener2 listener2 = new Listener2(countdownMessage);

            countdownMessage.SendNewMessageAfterSleep("Just message", time);
            listener1.Unregister(countdownMessage);
            listener2.Unregister(countdownMessage);
        }
    }
}
