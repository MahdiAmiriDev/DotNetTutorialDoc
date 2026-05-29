using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternSamples.Structural.Decorator
{
    internal class NotificationDecorator : Notification
    {
        private Notification notification;

        public NotificationDecorator(Notification notification)
        {
            this.notification = notification;
        }

        public virtual string Send()
        {
            return notification.Send();
        }
    }
}
