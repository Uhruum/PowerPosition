using Services.Abstractions;

namespace Services.Implementations
{
    public class NumberValidator : INumberValidator
    {
        public bool IsValid(string value)
        {
            if (string.IsNullOrEmpty(value.Trim()))
                return false;

            if (!int.TryParse(value.Trim(), out int vResult))
                return false;

            return true;
        }
    }
}