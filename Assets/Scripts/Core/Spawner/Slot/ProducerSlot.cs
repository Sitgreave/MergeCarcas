using DefaultNamespace.Slot;
using UnityEngine;

namespace DefaultNamespace
{
    public class ProducerSlot : MonoBehaviour, IContainer
    {
        private Transform _transform;
        public Vector3 Position => _transform.position;
        public IContainable CurrentContent { get; private set; }


        public void TrySetContent(IContainable content)
        {
            if (CurrentContent != null) return;
            CurrentContent = content;
            CurrentContent.MoveToContainer(this);
        }

        public void ForceSetContent(IContainable content)
        {
            CurrentContent = content;
            CurrentContent.MoveToContainer(this);
        }


        public void Clear()
        {
            CurrentContent = null;
        }
    }
}