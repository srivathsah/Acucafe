namespace AcuCafe
{
    public interface IDrinkValidatorFactory
    {
        IDrinkValidator Get(string type);
    }
}
