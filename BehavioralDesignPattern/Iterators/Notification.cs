using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.Iterators
{
    public class Notification
    {
        private string notification;

        public Notification(string notification)
        {
            this.notification = notification;
        }

        public string getNotification()
        {
            return this.notification;
        }
    }
}
