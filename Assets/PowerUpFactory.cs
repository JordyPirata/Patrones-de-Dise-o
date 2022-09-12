using UnityEngine;
using System;

namespace PowerUps
{
    public class PowerUpFactory : MonoBehaviour
    {
        [SerializeField] private PowerUp _speedPowerUp;

        public PowerUp Create(string id)
        {
            switch (id)
            {
                case"Speed":
                    return Instantiate(_speedPowerUp);
                default:
                    throw new ArgumentOutOfRangeException($"PowerUp with Id {id} does not exist");
            }
            
        }
    }
}
