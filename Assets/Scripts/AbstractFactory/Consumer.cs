using UnityEngine;

namespace Battle
{
    public class Consumer : MonoBehaviour
    {
        private BattleFactory currentBattleFactory;

        public void Configure(BattleFactory battleFactory)
        {
            currentBattleFactory = battleFactory;
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                currentBattleFactory.CreateHero("Warrior");
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                currentBattleFactory.CreateHero("Super");
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                currentBattleFactory.CreateWeapon("Axe");
            }
            if (Input.GetKeyDown(KeyCode.F4))
            {
                currentBattleFactory.CreateWeapon("Cloak");
            }
        }
    } 
}