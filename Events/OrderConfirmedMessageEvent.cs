using System;

namespace DynamicInvokation
{
    public class OrderConfirmedMessageEvent : IEvent
    {
        public string Name { get; set; }
        public float TotalCost { get; set; }
        Guid IEvent.MessageID => new();
    }
}
