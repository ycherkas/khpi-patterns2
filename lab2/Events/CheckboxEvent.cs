using Lab2.Abstract;

namespace Lab2.Events
{
    public class CheckboxEvent : EventArg
    {
        private readonly bool _checked;

        public bool IsChecked { get { return _checked; } }

        public CheckboxEvent(bool isChecked) : base()
        {
            _checked = isChecked;
        }
    }
}
