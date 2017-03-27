namespace AcuCafe
{
    public class TeaValidator : ITeaValidator
    {
        public bool Validate(string type, bool hasSugar, bool hasMilk)
        {
            return true;
        }
    }
}
