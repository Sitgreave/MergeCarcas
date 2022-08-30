using UnityEngine;

namespace DefaultNamespace.Slot
{
    public interface IContainer
    {
        public Vector3 Position { get; }
        public IContainable CurrentContent { get; }
        public void TrySetContent(IContainable content);
        public void ForceSetContent(IContainable content);
        void Clear();
    }
}