using System;
using Tester.Abstract;

namespace Tester.ThirdExample
{
    public class RegionalManager : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is Withdraw ? entity as Withdraw : null;
            string value = process.Amount <= 750000 ? $"{process.Amount} Para Çekme işlemi Bölge Sorumlusu Tarafından Onaylandı" : string.Empty;
            (value == string.Empty ? (Action)(() => base.Handle(entity)) : () => Console.WriteLine(value))();
        }
    }
}
