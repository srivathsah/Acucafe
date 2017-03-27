using AcuCafe.Models;
using AcuCafe.Plugins;
using System;
using System.Collections.Generic;

namespace AcuCafe.Factories
{
    public class DrinkFactory : IDrinkFactory
    {
        private Dictionary<string, IDrinkFactory> _drinkFactories;

        public DrinkFactory(IPluginsFactory pluginsFactory)
        {
            _drinkFactories = new Dictionary<string, IDrinkFactory>();
            foreach (var plugin in pluginsFactory.GetDrinkPlugins())
            {
                _drinkFactories.Add(plugin.GetDrinkName(), plugin.GetDrinkFactory());
            }
        }

        public void Add(string key, IDrinkFactory drinkFactory)
        {
            _drinkFactories.Add(key, drinkFactory);
        }

        public Drink Get(string type, bool hasSugar, bool hasMilk, Topping topping = null)
        {
            if (!_drinkFactories.ContainsKey(type))
            {
                throw new Exception("Drink Not Found");
            }

            return _drinkFactories[type].Get(type, hasSugar, hasMilk, topping);
        }
    }
}
