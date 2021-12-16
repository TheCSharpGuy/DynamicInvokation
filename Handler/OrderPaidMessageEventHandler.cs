using System;

namespace DynamicInvokation
{
    public class OrderPaidMessageEventHandler : IEventHandler
    {
        public string ProcessMessage<T>(T @event)
        {
            string msg;
            try
            {
                var eventMessage = (OrderPaidMessageEvent)(object)@event;
                msg = $"\nProcessing Event - OrderPaidMessageEvent({eventMessage.MessageID})" +
                    $"\n Order #:{eventMessage.OrderID}" +
                    $"\n Payment ref #:{eventMessage.PaymentRef}" +
                    $"\n Total Amount :{eventMessage.TotalCost}\n";
                Console.WriteLine(msg);
            }
            catch (Exception exp)
            {
                msg = $"Error:{exp.Message}";
            }
            return msg;
        }
    }
}
