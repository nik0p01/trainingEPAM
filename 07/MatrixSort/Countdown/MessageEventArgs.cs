namespace Countdown
{
    public class MessageEventArgs
    {
        private readonly string _message;
        public MessageEventArgs(string message)
        {
            _message = message;
        }
        public string Message { get { return _message; } }
    }
}
