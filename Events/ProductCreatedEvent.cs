using System;

namespace DynamicInvokation
{
    public record ProductCreatedEvent : IEvent
    {
        public string Title { get; set; }
        public Guid MessageID => Guid.NewGuid();
    }
}
