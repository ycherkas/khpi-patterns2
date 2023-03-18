using Lab2.Abstract;
using Lab2.Events;

namespace Lab2.Concrete
{
    public class Timespans : Component
    {
        private TimeSpan _selectedTimeSpan;
        private List<TimeSpan> _avaliableTimeSpans;

        private void OnChange(TimeSpan value)
        {
            _selectedTimeSpan = value;

            var eventArg = new TimespanEvent(value);

            _mediator.Notify(this, eventArg);
        }

        public void GenerateTimespans(DateTime date)
        {
            //TODO: implement
            _avaliableTimeSpans = new List<TimeSpan>();
        }

        public Timespans(IMediator mediator) : base(mediator)
        {
            _avaliableTimeSpans = new List<TimeSpan>();
        }
    }
}
