using Microsoft.Extensions.Logging;
using System;

namespace DynamicInvokation
{
    public class OrderConfirmedMessageEventHandler : IEventHandler
    {
        public string ProcessMessage<T>(T @event)
        {
            string msg;
            try
            {
                var eventMessage = (OrderConfirmedMessageEvent)(object)@event;
                msg = $"Processing Event - OrderMessageEvent\n Name:{eventMessage.Name}\n Cost:{eventMessage.TotalCost}\n";
                Console.WriteLine(msg);
            }
            catch(Exception exp)
            {
                msg = $"Error:{exp.Message}";
            }
            return msg;
        }
    }
}
