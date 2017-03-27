using System;
using AcuCafe.Models;

namespace AcuCafe
{
    public class Expresso : NoMilkDrink
    {
        private const double cost = 1.8;

        public override string Description
        {
            get { return "Expresso"; }
        }

        public override double Cost()
        {
            return base.Cost() + cost;
        }
    }
}
