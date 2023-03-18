using Lab2.Abstract;

namespace Lab2.Events
{
    public class TextboxEvent : EventArg
    {
        private readonly string _value;

        public string Value { get { return _value; } }

        public TextboxEvent(string value) : base()
        {
            _value = value;
        }
    }
}
