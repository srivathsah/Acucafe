namespace AcuCafe.Factories
{
    public class TeaFactory : ITeaFactory
    {
        public Drink Get(string type, bool hasSugar, bool hasMilk)
        {
            return new Tea { HasMilk = hasMilk, HasSugar = hasSugar };
        }
    }
}
