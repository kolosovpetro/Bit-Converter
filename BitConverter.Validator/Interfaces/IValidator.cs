namespace BitConverter.Validator.Interfaces
{
    public interface IValidator
    {
        bool IsValidBinary(string input);
        bool IsValidOctal(string input);
        bool IsValidDecimal(string input);
        bool IsValidHexadecimal(string input);
        bool Validate(string input, int inputBase);
    }
}