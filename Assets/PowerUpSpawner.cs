using UnityEngine;

namespace PowerUps
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField] private PowerUpFactory _powerUpFactory;
        private void Update()
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                _powerUpFactory.Create("Speed");
            }else if (Input.GetKey(KeyCode.Alpha2))
            {
                _powerUpFactory.Create("Drunk");
            }
        }
    }
}
