using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Decorator
{
    internal class SmsNotificationDecorator: NotificationDecorator
    {
        private Notification notification;
        public SmsNotificationDecorator(Notification notification)  : base(notification)
        {
            this.notification = notification;
        }

        public override string Send()
        {
            return base.Send() + " sms notification";
        }
    }
}
