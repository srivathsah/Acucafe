using AcuCafe.Factories;

namespace AcuCafe.Plugins
{
    public class TeaPlugin : IDrinkPlugin
    {
        public IDrinkFactory GetDrinkFactory()
        {
            return new TeaFactory();
        }

        public string GetDrinkName()
        {
            return nameof(Tea);
        }

        public IDrinkValidator GetDrinkValidator()
        {
            return new TeaValidator();
        }
    }
}
