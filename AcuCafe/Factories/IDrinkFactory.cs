using AcuCafe.Models;

namespace AcuCafe
{
    public interface IDrinkFactory
    {
        Drink Get(string type, bool hasSugar, bool hasMilk, Topping topping = null);
    }
}
