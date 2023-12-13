using Tester.Abstract;

namespace Tester.FirstExample
{
    public class Roofing : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is İron ? entity as İron : null;
            string value = (process is not null) ? $"{process.Name} Roofing was done" : "failed to Roofing";
            System.Console.WriteLine(value);
            base.Handle(entity);
        }
    }
}
