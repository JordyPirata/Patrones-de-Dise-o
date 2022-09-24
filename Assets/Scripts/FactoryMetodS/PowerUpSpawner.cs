 using UnityEngine;

namespace PowerUps
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField]
        public PowerUpConfiguration _powerUpConfiguration;
        private PowerUpFactory _powerUpFactory;

        void Awake()
        {
            _powerUpFactory = new PowerUpFactory(Instantiate(_powerUpConfiguration));
        }
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
