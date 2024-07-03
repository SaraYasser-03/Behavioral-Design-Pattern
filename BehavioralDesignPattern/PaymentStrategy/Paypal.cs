using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.PaymentStrategy
{
    public class Paypal:PayStrategy
    {
        public void pay()
        {
            Console.WriteLine("PayPal Paid");
        }
    }
}
