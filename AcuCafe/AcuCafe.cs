using AcuCafe.Models;
using System;

namespace AcuCafe
{
    public class AcuCafe
    {
        private readonly IDrinkFactory _drinkFactory;
        private readonly IDrinkValidatorFactory _drinkValidatorFactory;
        private const string _unableToProcess = "We are unable to prepare your drink.";

        public AcuCafe(IDrinkFactory drinkFactory, IDrinkValidatorFactory drinkValidatorFactory)
        {
            _drinkFactory = drinkFactory;
            _drinkValidatorFactory = drinkValidatorFactory;
        }

        public Tuple<string, Drink> OrderDrink(string type, bool hasMilk, bool hasSugar, Topping topping = null)
        {
            var message = string.Empty;
            var drink = default(Drink);

            var drinkValidator = _drinkValidatorFactory.Get(type);
            if (drinkValidator == null)
            {
                message = _unableToProcess;
                return new Tuple<string, Drink>(message, drink);
            }

            if (!drinkValidator.Validate(type, hasSugar, hasMilk, topping))
            {
                message = _unableToProcess;
                return new Tuple<string, Drink>(message, drink);
            }

            drink = _drinkFactory.Get(type, hasSugar, hasMilk, topping);
            if (drink == null)
            {
                message = _unableToProcess;
                return new Tuple<string, Drink>(message, drink);
            }

            message = drink.Prepare();
            return new Tuple<string, Drink>(message, drink);
        }
    }
}