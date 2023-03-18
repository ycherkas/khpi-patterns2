using Lab2.Abstract;

namespace Lab2.Events
{
    public class DatepickerEvent : EventArg
    {
        private readonly DateTime _value;

        public DateTime Value { get { return _value; } }

        public DatepickerEvent(DateTime value) : base()
        {
            _value = value;
        }
    }
}
