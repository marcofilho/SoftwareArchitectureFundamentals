namespace DemoDI.Cases
{
    public class OperationService
    {
        public OperationService(
                         ITransientOperation transient,
                         IScopedOperation scoped,
                         ISingletonOperation singleton,
                         ISingletonInstanceOperation singletonInstance)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }

        public ITransientOperation Transient { get; }
        public IScopedOperation Scoped { get; }
        public ISingletonOperation Singleton { get; }
        public ISingletonInstanceOperation SingletonInstance { get; }
    }

    public class Operation : ITransientOperation,
                              IScopedOperation,
                              ISingletonOperation,
                              ISingletonInstanceOperation
    {
        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid id)
        {
            OperationId = id;
        }

        public Guid OperationId { get; private set; }
    }

    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface ITransientOperation : IOperation
    {
    }

    public interface IScopedOperation : IOperation
    {
    }

    public interface ISingletonOperation : IOperation
    {
    }

    public interface ISingletonInstanceOperation : IOperation
    {
    }
}
