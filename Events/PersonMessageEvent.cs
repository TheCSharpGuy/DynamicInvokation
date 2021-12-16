using System;

namespace DynamicInvokation
{
    public class PersonMessageEvent : IEvent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        Guid IEvent.MessageID => new();
    }
}
