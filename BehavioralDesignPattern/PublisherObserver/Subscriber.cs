using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.PublisherObserver
{
    public abstract class Subscriber
    {
        protected Publisher publisher;

        protected Subscriber(Publisher publisher)
        {
            this.publisher = publisher;
        }

        public abstract void update();

    }
}
