using System;
using System.Reflection;

namespace DynamicInvokation
{
    public class Factory : IFactory
    {
        public static Factory GetInstance()
        {
            return new Factory();
        }

        public void DoProcess<T>(T @event)
        {
            var eventName = GetEventName<T>();
            string implName = GetEventHandlerName(eventName);
            Console.WriteLine($"#--\n{implName}\n");
            try
            {
                Type type = Type.GetType(implName, true);
                IEventHandler newInstance = (IEventHandler)Activator.CreateInstance(type);
                var msg = newInstance.ProcessMessage<T>(@event);
                Console.WriteLine($"\n{msg}\n--#");
            }
            catch(TypeLoadException texp)
            {
                Console.WriteLine($"Error:Missing handler for {eventName}\n--#");
            }
        }

        private string GetEventHandlerName(string typeName)
        {
            var sNamespaceHndl = Assembly.GetExecutingAssembly().FullName;
            sNamespaceHndl = $"{sNamespaceHndl.Substring(0, sNamespaceHndl.IndexOf(","))}.{typeName}Handler";
            return sNamespaceHndl;
        }

        private string GetEventName<T>() => typeof(T).Name;
    }
}
