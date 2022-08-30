using UnityEngine;

namespace DefaultNamespace
{
    public class Producer : IProducer<IProduct>
    {
        private Transform _transform;

        public Producer(uint interval, IProduct product)
        {
            Interval = interval;
            ProducedProduct = product;
        }

        public uint Interval { get; }
        public IProduct ProducedProduct { get; }


        public IProduct Produce()
        {
            var newProduct = ProducedProduct;
            Debug.Log("I produced!");
            return newProduct;
        }
    }
}