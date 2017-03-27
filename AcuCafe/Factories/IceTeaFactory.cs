using AcuCafe.Models;

namespace AcuCafe.Factories
{
    public class IceTeaFactory : IIceTeaFactory
    {
        public Drink Get(string type, bool hasSugar, bool hasMilk, Topping topping = null)
        {
            return new IceTea { HasSugar = hasSugar };
        }
    }
}
