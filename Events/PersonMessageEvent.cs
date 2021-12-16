using System;

namespace DynamicInvokation
{
    public record PersonMessageEvent : IEvent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        Guid IEvent.MessageID => new();
    }
}
