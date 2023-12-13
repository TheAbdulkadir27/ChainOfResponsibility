using Tester.Abstract;
using System;
namespace Tester.ThirdExample
{
    public class Teller : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is Withdraw ? entity as Withdraw : null;
            string value = process.Amount <= 40000 ? $"{process.Amount} Para Çekme işlemi Veznadar Tarafından Onaylandı" : string.Empty;
            (value == string.Empty ? (Action)(() => base.Handle(entity)) : () => Console.WriteLine(value))();
        }
    }
}
