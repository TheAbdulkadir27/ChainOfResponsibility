using System;
using Tester.Abstract;

namespace Tester.SecondExample
{
    public class Payment : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is Order ? entity as Order : null;
            string value = (process is not null) ? $"{process.Name} Payment was done" : "failed to Payment";
            Console.WriteLine(value);
            base.Handle(entity);
        }
    }
}
