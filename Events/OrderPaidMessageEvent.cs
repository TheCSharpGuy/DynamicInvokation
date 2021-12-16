using System;

namespace DynamicInvokation
{
    public record OrderPaidMessageEvent : IEvent
    {
        public string OrderID { get; set; }
        public string PaymentRef { get; set; }
        public float TotalCost { get; set; }
        Guid IEvent.MessageID => new();
    }

}
