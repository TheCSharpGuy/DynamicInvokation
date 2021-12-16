using System;

namespace DynamicInvokation
{
    public interface IEvent
    {
        public Guid MessageID { get; }
    }
}
