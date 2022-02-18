using System;
namespace DynamicInvokation
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ki;
            Random rnd;
            Factory factory = Factory.GetInstance();
            do
            {
                rnd = new();
                var rcvMessage1 = new PersonMessageEvent
                {
                    Name = $"Kha{Guid.NewGuid()}",
                    Age = rnd.Next(27,67)
                };
                var rcvMessage2 = new OrderConfirmedMessageEvent
                {
                    Name = $"Book{rnd.Next(1,100)}",
                    TotalCost = rnd.Next(100, 1067)
                };
                var rcvMessage3 = new OrderPaidMessageEvent
                {
                    OrderID = Guid.NewGuid().ToString(),
                    TotalCost = rnd.Next(100, 1067),
                    PaymentRef = Guid.NewGuid().ToString()
                };
                var rcvMessage4 = new OrderSuccessfullEvent
                {
                    Name = $"KJ{Guid.NewGuid()}",
                    Email = $"KJ{Guid.NewGuid()}@mail.com"
                };
                var rcvMessage5 = new ProductCreatedEvent
                {
                    Title = $"Product{Guid.NewGuid()}"
                };
                Console.Clear();
                Console.WriteLine("Press 'X' to exit, any other key to continue..");
                Console.WriteLine("----------------------------------------------");
                factory.DoProcess(rcvMessage1);
                factory.DoProcess(rcvMessage2);
                factory.DoProcess(rcvMessage3);
                factory.DoProcess(rcvMessage4);
                factory.DoProcess(rcvMessage5);
                ki = Console.ReadKey();
            } while (!(ki.KeyChar == 'X' || ki.KeyChar == 'x'));
        }
    }
}
