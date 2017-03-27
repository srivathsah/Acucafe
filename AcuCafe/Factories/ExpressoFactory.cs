using System;

namespace AcuCafe.Factories
{
    public class ExpressoFactory : IExpressoFactory
    {
        public Drink Get(string type, bool hasSugar, bool hasMilk)
        {
            return new Expresso { HasSugar = hasSugar };
        }
    }
}
