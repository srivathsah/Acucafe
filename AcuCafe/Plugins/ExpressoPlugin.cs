using AcuCafe.Factories;

namespace AcuCafe.Plugins
{
    public class ExpressoPlugin : IDrinkPlugin
    {
        public IDrinkFactory GetDrinkFactory()
        {
            return new ExpressoFactory();
        }

        public string GetDrinkName()
        {
            return nameof(Expresso);
        }

        public IDrinkValidator GetDrinkValidator()
        {
            return new ExpressoValidator();
        }
    }
}
