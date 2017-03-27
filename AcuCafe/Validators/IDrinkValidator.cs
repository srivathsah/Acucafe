using AcuCafe.Models;

namespace AcuCafe
{
    public interface IDrinkValidator
    {
        bool Validate(string type, bool hasSugar, bool hasMilk, Topping topping = null);
    }
}
