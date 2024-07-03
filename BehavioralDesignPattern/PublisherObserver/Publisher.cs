using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.PublisherObserver
{
    public class Publisher
    {
        protected List<Subscriber> subscribers = new List<Subscriber>();
        protected int state;

        public int State => this.state;

        public void setState(int state) {
            this.state = state;
            notify();
        }

        public void notify()
        {
            foreach (Subscriber s in subscribers) 
            {
                s.update();
            }
        }
        public void subscribe(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void unsubscribe(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
    }
}
