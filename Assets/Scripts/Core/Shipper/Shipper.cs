using UnityEngine;

namespace DefaultNamespace
{
    public class Shipper
    {
        [SerializeField] private CharacterSpawner _producerSpawner;


        public void Ship(Producer producer)
        {
        }

        private Vector3 GetEmptySlot()
        {
            return new Vector3();
        }
    }
}