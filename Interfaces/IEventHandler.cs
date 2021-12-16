namespace DynamicInvokation
{
    public interface IEventHandler
    {
        public string ProcessMessage<T>(T @event);
    }
}
