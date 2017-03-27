namespace AcuCafe.Factories
{
    public class IceTeaFactory : IIceTeaFactory
    {
        public Drink Get(string type, bool hasSugar, bool hasMilk)
        {
            return new IceTea { HasSugar = hasSugar };
        }
    }
}
