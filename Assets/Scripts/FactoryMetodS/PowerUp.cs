using UnityEngine;

namespace PowerUps
{
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] public string _id;
        public string Id => _id;
    }
}

