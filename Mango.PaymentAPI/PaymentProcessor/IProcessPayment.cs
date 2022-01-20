using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.PaymentAPI.PaymentProcessor
{
    public interface IProcessPayment
    {
        bool PaymentProcessor();
    }
}