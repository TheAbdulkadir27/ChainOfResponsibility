using System;
using System.ComponentModel;
using Tester.FirstExample;
using Tester.SecondExample;
using Tester.ThirdExample;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            İron iron = new İron();
            iron.Name = "B/11";

            var cutting = new Cutting();
            var Roofing = new Roofing();
            var Welding = new Welding();

            cutting.SetNext(Roofing.SetNext(Welding));
            cutting.Handle(iron);

            Console.WriteLine("------------------------------------------------");

            Order order = new Order();
            order.Name = "Paint Note";

            var Payment = new Payment();
            var invoice = new İnVoice();
            var shipping = new Shipping();

            Payment.SetNext(invoice.SetNext(shipping));

            Payment.Handle(order);



            Console.WriteLine("-------------------------------------------------------------");

            var withdraw = new Withdraw(Guid.NewGuid().ToString(), 480000, "TRY", "TR7211111111111111111111");
            var Teller = new Teller();
            var manager = new Manager();
            var generalmanager = new GeneralManager();
            var regionalmanager = new RegionalManager();

            Teller.SetNext(manager.SetNext(generalmanager.SetNext(regionalmanager)));
            Teller.Handle(withdraw);
            Console.ReadKey();
        }
    }
}
