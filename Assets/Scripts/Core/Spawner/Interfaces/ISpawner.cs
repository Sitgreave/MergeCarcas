using UnityEngine;

namespace DefaultNamespace
{
    public interface ISpawner<T>
    {
        T Spawn(T target, Transform parent);
    }
}