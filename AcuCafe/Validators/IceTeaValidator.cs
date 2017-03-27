namespace AcuCafe
{
    public class IceTeaValidator : IIceTeaValidator
    {
        public bool Validate(string type, bool hasSugar, bool hasMilk)
        {
            return !hasMilk;
        }
    }
}
