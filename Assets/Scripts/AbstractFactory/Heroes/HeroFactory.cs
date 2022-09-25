using Object = UnityEngine.Object;

namespace Heroes
{
    public class HeroFactory
    {
        private readonly HeroesConfiguration _heroConfiguration;

        public HeroFactory(HeroesConfiguration heroConfiguration)
        {
            _heroConfiguration = heroConfiguration;
        }

        public Hero Create(string id)
        {
            var hero = _heroConfiguration.GetHeroPrefabById(id);
            return Object.Instantiate(hero);
        }
    }
}