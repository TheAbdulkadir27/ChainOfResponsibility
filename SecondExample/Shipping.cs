using Tester.Abstract;

namespace Tester.SecondExample
{
    public class Shipping : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is Order ? entity as Order : null;
            string value = (process is not null) ? $"{process.Name} shipping was done" : "failed to shipping";
            System.Console.WriteLine(value);
            base.Handle(entity);
        }
    }
}
