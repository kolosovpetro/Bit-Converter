using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Numbers
{
    public class HexadecimalNumber : INumber
    {
        public int Base { get; } = 16;
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public HexadecimalNumber(string input)
        {
            var number = new NumberModel(input, Base);
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }

        public override string ToString()
        {
            return Prefix.Hexadecimal + IntegerPart + Separator.Dot + FloatPart;
        }
    }
}