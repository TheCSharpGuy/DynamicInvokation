using System;
using System.Reflection;

namespace DynamicInvokation
{
    public class Factory
    {
        public static Factory GetInstance()
        {
            return new Factory();
        }
        
        public void DoProcess<T>(T @event)
        {
            var eventName = GetEventName<T>();
            string implName = GetEventHandlerName(eventName);
            Console.WriteLine(implName);
            try
            {
                Type type = Type.GetType(implName, true);
                IEventHandler newInstance = (IEventHandler)Activator.CreateInstance(type);
                var msg = newInstance.ProcessMessage<T>(@event);
                Console.WriteLine(msg);
            }
            catch(TypeLoadException texp)
            {
                Console.WriteLine($"Error:Missing handler for {eventName}\n{texp.Message}");
            }
        }

        public string GetEventHandlerName(string typeName)
        {
            var sNamespaceHndl = Assembly.GetExecutingAssembly().FullName;
            sNamespaceHndl = $"{sNamespaceHndl.Substring(0, sNamespaceHndl.IndexOf(","))}.{typeName}Handler";
            return sNamespaceHndl;
        }

        public string GetEventName<T>() => typeof(T).Name;
    }
}
