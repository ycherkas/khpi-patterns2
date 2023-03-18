using Lab2.Abstract;
using Lab2.Events;

namespace Lab2.Concrete
{
    public class Datepicker : Component
    {
        private DateTime _value;

        public DateTime Date { get { return _value; } }

        private void OnChange(DateTime value)
        {
            _value = value;

            var eventArg = new DatepickerEvent(value);

            _mediator.Notify(this, eventArg);
        }

        public Datepicker(IMediator mediator) : base(mediator)
        {
        }
    }
}
