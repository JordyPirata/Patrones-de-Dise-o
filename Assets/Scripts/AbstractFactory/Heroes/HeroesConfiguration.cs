using System;
using System.Collections.Generic;
using UnityEngine;

namespace Heroes
{
    [CreateAssetMenu(menuName = "Custom/Hero configuration")]
    public class HeroeConfiguration : ScriptableObject
    {
        [SerializeField] private Hero[] _heroes;
        private Dictionary<string, Hero> _idToPowerUp;

        private void Awake()
        {
            _idToPowerUp = new Dictionary<string, Hero>();
            foreach (var hero in _heroes)
            {
                _idToPowerUp.Add(hero.Id, hero);
            }
        }

        public Hero GetHeroPrefabById(string id)
        {
            if (!_idToPowerUp.TryGetValue(id, out Hero hero))
            {
                throw new Exception($"Hero with id {id} does not exist");
            }
            return hero;
        }
    }
}