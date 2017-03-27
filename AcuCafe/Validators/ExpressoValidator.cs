using System;

namespace AcuCafe
{
    public class ExpressoValidator : IExpressoValidator
    {
        public bool Validate(string type, bool hasSugar, bool hasMilk)
        {
            return !hasMilk;
        }
    }
}
