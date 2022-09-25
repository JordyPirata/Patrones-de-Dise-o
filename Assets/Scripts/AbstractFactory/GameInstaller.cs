using UnityEngine;
using Heroes;
using Weapons;

namespace Battle
{
    public class GameInstaller : MonoBehaviour
    {
        [SerializeField] private HeroesConfiguration heroesConfiguration;
        [SerializeField] private WeaponsConfiguration weaponsConfiguration;
        private void Start()
        {
            var heroFactory = new HeroFactory(Instantiate(heroesConfiguration));
            var weaponFactory = new WeaponFactory(Instantiate(weaponsConfiguration));

            var consumerGameObject = new GameObject();
            var consumer = consumerGameObject.AddComponent<Consumer>();
            consumer.Configure(new BattleFactory(heroFactory, weaponFactory));
        }
    }
}