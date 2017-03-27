namespace AcuCafe.Plugins
{
    public interface IDrinkPlugin
    {
        IDrinkFactory GetDrinkFactory();
        IDrinkValidator GetDrinkValidator();
        string GetDrinkName();
    }
}
