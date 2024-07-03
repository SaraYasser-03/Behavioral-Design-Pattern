using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPattern.PaymentStrategy
{
    public class PayContext
    {
        private PayStrategy strategy;
        public PayContext(PayStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void payOrder()
        {
            this.strategy.pay();
        }
    }
}
