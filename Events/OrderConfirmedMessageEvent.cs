using System;

namespace DynamicInvokation
{
    public record OrderConfirmedMessageEvent : IEvent
    {
        public string Name { get; set; }
        public float TotalCost { get; set; }
        public Guid MessageID => new();
    }
}
