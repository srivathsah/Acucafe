using AcuCafe.Models;

namespace AcuCafe
{
    public class DrinkValidator : IDrinkValidator
    {
        private readonly IDrinkValidatorFactory _drinkValidatorFactory;

        public DrinkValidator(IDrinkValidatorFactory drinkValidatorFactory)
        {
            _drinkValidatorFactory = drinkValidatorFactory;
        }

        public bool Validate(string type, bool hasSugar, bool hasMilk, Topping topping = null)
        {
            return _drinkValidatorFactory.Get(type).Validate(type, hasSugar, hasMilk, topping);
        }
    }
}
