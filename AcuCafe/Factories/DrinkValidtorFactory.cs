using AcuCafe.Plugins;
using System.Collections.Generic;

namespace AcuCafe.Factories
{
    public class DrinkValidtorFactory : IDrinkValidatorFactory
    {
        private Dictionary<string, IDrinkValidator> _drinkValidatorFactories;

        public DrinkValidtorFactory(IPluginsFactory pluginsFactory)
        {
            _drinkValidatorFactories = new Dictionary<string, IDrinkValidator>();
            foreach (var plugin in pluginsFactory.GetDrinkPlugins())
            {
                _drinkValidatorFactories.Add(plugin.GetDrinkName(), plugin.GetDrinkValidator());
            }
        }

        public void Add(string key, IDrinkValidator drinkFactory)
        {
            _drinkValidatorFactories.Add(key, drinkFactory);
        }

        public IDrinkValidator Get(string type)
        {
            return _drinkValidatorFactories[type];
        }
    }
}
