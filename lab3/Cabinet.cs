namespace Lab3
{
    public class Cabinet
    {
        public bool PersonalNotificationsAllowed { get; set; }

        public bool PromodionNotificationsAllowed { get; set; }

        public bool AdNotificationsAllowed { get; set; }


        public Memento Save()
        {
            //TODO: implement logic to aply flags for actual notifications

            return new Memento(PersonalNotificationsAllowed, PromodionNotificationsAllowed, AdNotificationsAllowed);
        }

        public void Restore(Memento memento)
        {
            PersonalNotificationsAllowed = memento.PersonalNotificationsAllowed;
            PromodionNotificationsAllowed = memento.PromodionNotificationsAllowed;
            AdNotificationsAllowed = memento.AdNotificationsAllowed;
        }

        public void ShowSate()
        {
            Console.WriteLine($"PersonalNotificationsAllowed={PersonalNotificationsAllowed};PromodionNotificationsAllowed={PromodionNotificationsAllowed};AdNotificationsAllowed={AdNotificationsAllowed};");
        }
    }
}
