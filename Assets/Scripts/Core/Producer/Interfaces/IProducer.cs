namespace DefaultNamespace
{
    public interface IProducer<T> where T : IProduct
    {
        public T ProducedProduct { get; }
        public T Produce();
    }
}