namespace Tester.Abstract
{
    public abstract class HandlerBase : IHandler
    {
        private IHandler Next;
        public virtual void Handle<T>(T entity) where T : IHand => Next?.Handle(entity);
        public IHandler SetNext(IHandler currenthandler)
        {
            Next = currenthandler;
            return this;
        }
    }
}
