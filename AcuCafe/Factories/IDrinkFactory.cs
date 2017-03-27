namespace AcuCafe
{
    public interface IDrinkFactory
    {
        Drink Get(string type, bool hasSugar, bool hasMilk);
    }
}
