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
                msg = $"Processing Event - OrderPaidMessageEvent" +
                    $"\n Order #:{eventMessage.OrderID}" +
                    $"\n Payment ref #:{eventMessage.PaymentRef}\n" +
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
