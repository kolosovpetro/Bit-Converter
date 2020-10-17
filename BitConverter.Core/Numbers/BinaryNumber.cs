using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Models;

namespace BitConverter.Numbers
{
    public class BinaryNumber : INumber
    {
        public int Base { get; }
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public BinaryNumber(string input)
        {
            INumber number = new NumberModel(input, 2);
            Base = number.Base;
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }

        public override string ToString()
        {
            return IntegerPart + Separator.Dot + FloatPart;
        }
    }
}