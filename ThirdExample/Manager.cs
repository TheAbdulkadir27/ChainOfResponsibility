using System;
using Tester.Abstract;

namespace Tester.ThirdExample
{
    public class Manager : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is Withdraw ? entity as Withdraw : null;
            string value = process.Amount <= 70000 ? $"{process.Amount} Para Çekme işlemi Yönetici Tarafından Onaylandı" : string.Empty;
            (value == string.Empty ? (Action)(() => base.Handle(entity)) : () => Console.WriteLine(value))();
        }
    }
}
