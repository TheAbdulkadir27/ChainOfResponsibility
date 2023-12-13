using Tester.Abstract;

namespace Tester.SecondExample
{
    public class Order : IHand
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
