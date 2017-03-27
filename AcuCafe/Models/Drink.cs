using System;

namespace AcuCafe
{
    public abstract class Drink
    {
        public const double SugarCost = 0.5;

        public bool HasSugar { get; set; }
        public abstract string Description { get; }

        public virtual double Cost()
        {
            return HasSugar ? SugarCost : 0;
        }

        public virtual string Prepare()
        {
            string message = "We are preparing the following drink for you: " + Description;

            if (HasSugar)
                message += "with sugar";
            else
                message += "without sugar";

            return message;
        }
    }
}
