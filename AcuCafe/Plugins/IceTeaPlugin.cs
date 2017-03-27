using AcuCafe.Factories;

namespace AcuCafe.Plugins
{
    public class IceTeaPlugin : IDrinkPlugin
    {
        public IDrinkFactory GetDrinkFactory()
        {
            return new IceTeaFactory();
        }

        public string GetDrinkName()
        {
            return nameof(IceTea);
        }

        public IDrinkValidator GetDrinkValidator()
        {
            return new IceTeaValidator();
        }
    }
}
