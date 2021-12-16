using System;

namespace DynamicInvokation
{
    public class PersonMessageEventHandler : IEventHandler
    {
        public string ProcessMessage<T>(T @event)
        {
            string msg;
            try
            {
                var eventMessage = (PersonMessageEvent)(object)@event;
                msg = $"Processing Event - PersonMessageEvent\n Name:{eventMessage.Name}\n Age:{eventMessage.Age}\n";
                Console.WriteLine(msg);
            }
            catch (Exception exp)
            {
                msg = $"Error:{exp.Message}";
            }
            return msg;
        }
    }
}
