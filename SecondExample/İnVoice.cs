using Tester.Abstract;

namespace Tester.SecondExample
{
    public class İnVoice : HandlerBase
    {
        public override void Handle<T>(T entity)
        {
            var process = entity is Order ? entity as Order : null;
            string value = (process is not null) ? $"{process.Name} İnVoice was cutting" : "failed to invoice cut";
            System.Console.WriteLine(value);
            base.Handle(entity);
        }
    }
}
