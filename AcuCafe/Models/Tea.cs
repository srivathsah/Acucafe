namespace AcuCafe
{
    public class Tea : MilkDrink
    {
        private const double cost = 1;
        public override string Description
        {
            get { return "Hot tea"; }
        }

        public override double Cost()
        {
            return base.Cost() + cost;
        }
    }
}
