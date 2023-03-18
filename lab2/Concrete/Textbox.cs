using Lab2.Abstract;
using Lab2.Events;

namespace Lab2.Concrete
{
    public class Textbox : Component
    {
        private string _value;

        public string Value { get { return _value; } }

        public bool IsRequired { get; set; }

        private void OnChange(string value)
        {
            _value = value;

            var eventArg = new TextboxEvent(value);

            _mediator.Notify(this, eventArg);
        }

        public Textbox(IMediator mediator) : base(mediator)
        {
        }
    }
}
