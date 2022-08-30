using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterSpawner : MonoBehaviour, ISpawner<Character>
    {
        public Character Spawn(Character prefab, Transform parent)
        {
            return Instantiate(prefab, parent);
        }
    }
}