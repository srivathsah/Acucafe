namespace AcuCafe
{
    public interface IDrinkValidator
    {
        bool Validate(string type, bool hasSugar, bool hasMilk);
    }
}
