using Lab2.Abstract;
using Lab2.Events;

namespace Lab2.Concrete
{
    public class Checkbox : Component
    {
        private bool _isChecked;

        public bool IsChecked { get { return _isChecked; } }

        private void OnCheck(bool isChecked)
        {
            _isChecked = isChecked;

            var eventObj = new CheckboxEvent(isChecked);

            this._mediator.Notify(this, eventObj);
        }

        public Checkbox(IMediator mediator) : base(mediator)
        {
        }
    }
}
