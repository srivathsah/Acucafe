using AcuCafe.Models;

namespace AcuCafe
{
    public class TeaValidator : ITeaValidator
    {
        public bool Validate(string type, bool hasSugar, bool hasMilk, Topping topping = null)
        {
            return true;
        }
    }
}
