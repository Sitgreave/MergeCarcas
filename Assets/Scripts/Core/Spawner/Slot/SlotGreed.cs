using DefaultNamespace.Slot;
using UnityEngine;

namespace Core.Spawner.Slot
{
    public sealed class SlotGreed<T> : MonoBehaviour
    {
        [SerializeField] private uint _horizontalCount;
        [SerializeField] private uint _verticalCount;

        // private SlotPoint<T>[,] _slotPoints;
        //
        // public void Initialize()
        // {
        //     _slotPoints = new SlotPoint<T>[_horizontalCount, _verticalCount];
        // }
    }
}