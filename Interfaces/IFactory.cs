namespace DynamicInvokation
{
    public interface IFactory
    {
        public void DoProcess<T>(T @event);

    }
}
