﻿using Mango.OrderAPI.Mango.MessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.PaymentAPI.RabbitMQSender
{
    public interface IRabbitMQPaymentMessageSender
    {
        void SendMessage(BaseMessage baseMessage);
    }
}