using System;

namespace DynamicInvokation
{
    public class OrderPaidMessageEvent : IEvent
    {
        public string OrderID { get; set; }
        public string PaymentRef { get; set; }
        public float TotalCost { get; set; }
        Guid IEvent.MessageID => new();
    }

}
