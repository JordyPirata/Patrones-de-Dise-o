using UnityEngine;

namespace Heroes
{
    public abstract class Hero : MonoBehaviour
    {
        [SerializeField] public string _id;
        public string Id => _id;
    }
}