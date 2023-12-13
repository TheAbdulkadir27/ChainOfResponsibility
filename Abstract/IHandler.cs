namespace Tester.Abstract
{
    public interface IHandler
    {
        IHandler SetNext(IHandler currenthandler);
        void Handle<T>(T entity) where T : IHand;
    }
}
