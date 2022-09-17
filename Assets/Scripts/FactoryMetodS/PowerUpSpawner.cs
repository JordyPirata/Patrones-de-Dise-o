 using UnityEngine;

namespace PowerUps
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField] private PowerUpFactory _powerUpFactory;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _powerUpFactory.Create("Speed");
            }else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _powerUpFactory.Create("Drunk");
            }
        }
    }
}
