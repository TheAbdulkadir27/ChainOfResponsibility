using Tester.Abstract;

namespace Tester.FirstExample
{
    public  class Welding : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is İron ? entity as İron : null;
            string value = (process is not null) ? $"{process.Name} Welding was done" : "failed to Welding";
            System.Console.WriteLine(value);
            base.Handle(entity);
        }
    }
}
