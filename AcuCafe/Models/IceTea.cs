namespace AcuCafe
{
    public class IceTea:NoMilkDrink
    {
        private const double cost = 1.5;
        public override string Description
        {
            get { return "Ice tea"; }
        }

        public override double Cost()
        {
            return base.Cost() + cost;
        }
    }
}
