using System;

namespace DynamicInvokation
{
    public record OrderSuccessfullEvent : IEvent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid MessageID => Guid.NewGuid();
    }
}
