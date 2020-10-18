using BitConverter.Exceptions;
using BitConverter.Interfaces;
using BitConverter.Validator.Auxiliaries;
using BitConverter.Validator.Interfaces;

namespace BitConverter.Models
{
    public class NumberModel : INumber
    {
        private readonly IValidator _validator = new Validator.Implementations.Validator();

        public int Base { get; }
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public NumberModel(string input, int inputBase)
        {
            if (!_validator.Validate(input, inputBase))
                throw new InvalidNumberFormatException("Entered number has a wrong format.");

            var split = input.Split(Separator.Dot);
            IntegerPart = split[0];
            FloatPart = split[1];
            Base = inputBase;
        }

        public override string ToString()
        {
            return IntegerPart + Separator.Dot + FloatPart;
        }
    }
}