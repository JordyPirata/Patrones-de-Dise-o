using Object = UnityEngine.Object;

namespace Weapons
{
    public class WeaponFactory
    {
        private readonly WeaponConfiguration _weaponConfiguration;

        public WeaponFactory(WeaponConfiguration weaponConfiguration)
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