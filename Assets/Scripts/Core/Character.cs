using DefaultNamespace.Slot;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(Producer))]
    public class Character : MonoBehaviour, IContainable
    {
        [SerializeField] private Producer _producer;

        public void MoveToContainer(IContainer container)
        {
            //MOVE CODE
        }
    }
}