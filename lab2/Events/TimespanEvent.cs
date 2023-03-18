using Lab2.Abstract;

namespace Lab2.Events
{
    public class TimespanEvent : EventArg
    {
        private readonly TimeSpan _value;

        public TimeSpan Value { get { return _value; } }

        public TimespanEvent(TimeSpan value) : base()
        {
            _value = value;
        }
    }
}
