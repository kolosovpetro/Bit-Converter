using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Numbers
{
    public class BinaryNumber : INumber
    {
        public int Base { get; } = 2;
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public BinaryNumber(string input)
        {
            var number = new NumberModel(input, Base);
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }

        public override string ToString()
        {
            return IntegerPart + Separator.Dot + FloatPart;
        }
    }
}