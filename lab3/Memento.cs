namespace Lab3
{
    public class Memento
    {
        public bool PersonalNotificationsAllowed { get; private set; }

        public bool PromodionNotificationsAllowed { get; private set; }

        public bool AdNotificationsAllowed { get; private set; }

        public Memento(bool personalNotificationsAllowed, bool promodionNotificationsAllowed, bool adNotificationsAllowed)
        {
            PersonalNotificationsAllowed = personalNotificationsAllowed;

            PromodionNotificationsAllowed = promodionNotificationsAllowed;

            AdNotificationsAllowed = adNotificationsAllowed;
        }
    }
}
