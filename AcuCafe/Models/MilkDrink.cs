using System;

namespace AcuCafe
{
    public class MilkDrink : Drink
    {
        private const string _description = nameof(MilkDrink);
        private const double _milkCost = 0.5;

        public bool HasMilk { get; set; }

        public override string Description
        {
            get { return _description; }
        }

        public override double Cost()
        {
            return HasMilk ? (base.Cost() + _milkCost) : base.Cost();
        }

        public override string Prepare()
        {
            string message = "We are preparing the following drink for you: " + Description;
            if (HasMilk)
                message += "with milk";
            else
                message += "without milk";

            if (HasSugar)
                message += "with sugar";
            else
                message += "without sugar";

            return message;
        }
    }
}
