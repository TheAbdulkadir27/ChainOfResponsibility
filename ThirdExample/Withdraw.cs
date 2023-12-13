using Tester.Abstract;
namespace Tester.ThirdExample
{
    public class Withdraw : IHand
    {
        public string CustomerId { get; }
        public decimal Amount { get; }
        public string CurrencyType { get; }
        public string SoruceAccountId { get; }

        public Withdraw(string customerId, decimal amount, string currencyType, string soruceAccountId)
        {
            CustomerId = customerId;
            Amount = amount;
            CurrencyType = currencyType;
            SoruceAccountId = soruceAccountId;
        }
    }
}
