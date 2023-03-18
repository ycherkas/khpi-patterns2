using Lab2.Abstract;
using Lab2.Events;

namespace Lab2.Concrete
{
    public class DeliverFlowerPage : IMediator
    {
        private Textbox _txtName;
        private Textbox _txtPhone;
        private Checkbox _chkTakeFromShop;
        private Checkbox _chkOtherReciever;
        private Datepicker _dtpDeliveryDate;
        private Timespans _tmsDeliveryTime;


        public void Notify(Component sender, EventArg eventArg)
        {
            switch (sender)
            {
                case null:
                    throw new ArgumentNullException("Sender component cannot be null");
                case var _ when sender == _chkTakeFromShop:
                    var takeFromShopEvent = (CheckboxEvent)eventArg;
                    _txtName.IsActive = !takeFromShopEvent.IsChecked && _chkOtherReciever.IsChecked;
                    _txtPhone.IsActive = !takeFromShopEvent.IsChecked && _chkOtherReciever.IsChecked;
                    _dtpDeliveryDate.IsActive = !takeFromShopEvent.IsChecked;
                    _chkOtherReciever.IsActive = !takeFromShopEvent.IsChecked;
                    break;
                case var _ when sender == _chkOtherReciever:
                    var otherRecieverEvent = (CheckboxEvent)eventArg;
                    _txtName.IsActive = otherRecieverEvent.IsChecked;
                    _txtName.IsRequired = otherRecieverEvent.IsChecked;
                    _txtPhone.IsActive = otherRecieverEvent.IsChecked;
                    _txtPhone.IsRequired = otherRecieverEvent.IsChecked;
                    break;
                case var _ when sender == _dtpDeliveryDate:
                    var datepickerEvent = (DatepickerEvent)eventArg;
                    _tmsDeliveryTime.GenerateTimespans(datepickerEvent.Value);
                    _tmsDeliveryTime.IsActive = true;
                    break;
                default:
                    throw new ArgumentException("Unknown sender");
            }
        }

        public DeliverFlowerPage()
        {
            _txtName = new Textbox(this);
            _txtPhone = new Textbox(this);
            _chkOtherReciever = new Checkbox(this);
            _chkTakeFromShop = new Checkbox(this);
            _dtpDeliveryDate = new Datepicker(this);
            _tmsDeliveryTime = new Timespans(this);
        }
    }
}
