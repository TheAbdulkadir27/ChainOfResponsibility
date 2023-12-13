using System;
using Tester.Abstract;

namespace Tester.ThirdExample
{
    public class GeneralManager : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is Withdraw ? entity as Withdraw : null;
            string value = process.Amount <= 150000 ? $"{process.Amount} Para Çekme işlemi Genel Müdür Tarafından Onaylandı" : string.Empty;
            (value == string.Empty ? (Action)(() => base.Handle(entity)) : () => Console.WriteLine(value))();
        }
    }
}
