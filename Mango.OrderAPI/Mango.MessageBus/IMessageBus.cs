using Mango.OrderAPI.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.OrderAPI.Mango.MessageBus
{
    public interface IMessageBus
    {
        Task PublishMessage(BaseMessage message, string topicName);
        Task PublishMessage(UpdatePaymentResultMessage updatePaymentResultMessage, string orderupdatepaymentresulttopic);
    }
}