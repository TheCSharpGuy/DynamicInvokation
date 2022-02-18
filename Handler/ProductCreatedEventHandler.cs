using System;

namespace DynamicInvokation
{
    public class ProductCreatedEventHandler : IEventHandler
    {
        public string ProcessMessage<T>(T @event)
        {
            string msg;
            try
            {
                var eventMessage = (ProductCreatedEvent)(object)@event;
                msg = $"\nProcessing Event - ProductCreatedEvent({eventMessage.MessageID})" +
                    $"\n Name:{eventMessage.Title}\n";
                //Console.WriteLine(msg);
            }
            catch (Exception exp)
            {
                msg = $"Error:{exp.Message}";
            }
            return msg;
        }
    }
}
