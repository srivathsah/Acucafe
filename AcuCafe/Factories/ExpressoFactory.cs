using AcuCafe.Models;
using System;

namespace AcuCafe.Factories
{
    public class ExpressoFactory : IExpressoFactory
    {
        public Drink Get(string type, bool hasSugar, bool hasMilk, Topping topping = null)
        {
            return new Expresso { HasSugar = hasSugar, Topping = topping };
        }
    }
}
