namespace DesingPatternSamples.Structural.Decorator
{
    internal class EmailNotificationDecorator : NotificationDecorator
    {
        private Notification notification;
        public EmailNotificationDecorator(Notification notification) : base(notification)
        {
            this.notification = notification;
        }

        public override string Send()
        {
            return base.Send() + " email notification";
        }
    }
}
