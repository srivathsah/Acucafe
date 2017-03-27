using AcuCafe.Models;

namespace AcuCafe
{
    public class IceTeaValidator : IIceTeaValidator
    {
        public bool Validate(string type, bool hasSugar, bool hasMilk, Topping topping = null)
        {
            return !hasMilk;
        }
    }
}
