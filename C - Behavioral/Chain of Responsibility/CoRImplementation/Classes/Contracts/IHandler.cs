namespace CoRImplementation.Classes.Contracts
{
    public interface IHandler<T> where T : class
    {
        public IHandler<T> SetSuccessor(IHandler<T> successor);
        void Handle(T request);
    }
}
