using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.PublisherObserver
{
    public class BinarySubscriber:Subscriber
    {
        public BinarySubscriber(Publisher publisher):base(publisher)
        {
            publisher.subscribe(this);
        }
            
        public override void update()
        {
            Console.WriteLine("Binary Update: " + publisher.State);
        }
    }
}
