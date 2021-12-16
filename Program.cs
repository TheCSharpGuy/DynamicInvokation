using System;
namespace DynamicInvokation
{
    class Program
    {
        static void Main(string[] args)
        {
            var rcvMessage1 = new PersonMessageEvent
            {
                Name = "Kha", Age = 37
            };
            var rcvMessage2 = new OrderConfirmedMessageEvent
            {
                Name = "Book1",
                TotalCost = 100
            };
            var rcvMessage3 = new OrderPaidMessageEvent
            {
                OrderID = Guid.NewGuid().ToString(),
                TotalCost = 100,
                PaymentRef = Guid.NewGuid().ToString()
            };

            Console.WriteLine("Hello World!");
            
            Factory factory = Factory.GetInstance();
            
            factory.DoProcess(rcvMessage1);
            factory.DoProcess(rcvMessage2); 
            factory.DoProcess(rcvMessage3);

        }

    }
}
