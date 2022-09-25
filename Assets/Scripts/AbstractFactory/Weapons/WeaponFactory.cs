using Object = UnityEngine.Object;

namespace Weapons
{
    public class WeaponFactory
    {
        private readonly WeaponsConfiguration _weaponConfiguration;

        public WeaponFactory(WeaponsConfiguration weaponConfiguration)
        {
            _weaponConfiguration = weaponConfiguration;
        }

        public Weapon Create(string id)
        {
            var weapon = _weaponConfiguration.GetWeaponPrefabById(id);
            return Object.Instantiate(weapon);
        }
    }
}