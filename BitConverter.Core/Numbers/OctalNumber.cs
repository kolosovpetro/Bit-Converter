using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Numbers
{
    public class OctalNumber : INumber
    {
        public int Base { get; } = 8;
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public OctalNumber(string input)
        {
            var number = new NumberModel(input, Base);
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }

        public override string ToString()
        {
            return Prefix.Octal + IntegerPart + Separator.Dot + FloatPart;
        }
    }
}