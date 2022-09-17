using UnityEngine;
using System;
using System.Collections.Generic;

namespace PowerUps
{
    public class PowerUpFactory : MonoBehaviour
    {
        [SerializeField] private PowerUp [] _powerUps;
        private Dictionary<string,PowerUp> _idToPowerUp; 

        private void Awake()
        {
            _idToPowerUp = new Dictionary<string, PowerUp>();
            foreach (var powerUp in _powerUps)
            {
                _idToPowerUp.Add(powerUp.Id, powerUp);
            }
        }
        public PowerUp Create(string id)
        {
            if(!_idToPowerUp.TryGetValue(id, out PowerUp powerUp))
            {
                throw new Exception($"PowerUp with id {id} does not exist");
            }
            return Instantiate(powerUp);
        }
    }
}
