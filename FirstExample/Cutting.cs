using Tester.Abstract;

namespace Tester.FirstExample
{
    public class Cutting : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is İron ? entity as İron : null;
            string value = (process is not null) ? $"{process.Name} Cutting was done" : "failed to cut";
            System.Console.WriteLine(value);
            base.Handle(entity);
        }
    }
}
