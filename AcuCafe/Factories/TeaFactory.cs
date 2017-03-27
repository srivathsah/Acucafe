using AcuCafe.Models;

namespace AcuCafe.Factories
{
    public class TeaFactory : ITeaFactory
    {
        public Drink Get(string type, bool hasSugar, bool hasMilk, Topping topping = null)
        {
            return new Tea { HasMilk = hasMilk, HasSugar = hasSugar };
        }
    }
}
