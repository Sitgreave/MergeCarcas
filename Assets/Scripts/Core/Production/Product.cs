namespace DefaultNamespace
{
    public abstract class Product : IProduct
    {
        protected Product(uint price)
        {
            Price = price;
        }

        public uint Price { get; }
        
    }
}