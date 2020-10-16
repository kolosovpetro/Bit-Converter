using BitConverter.Interfaces;
using BitConverter.Models;

namespace BitConverter.Numbers
{
    public class HexadecimalNumber : INumber
    {
        public int Base { get; set; }
        public string IntegerPart { get; set; }
        public string FloatPart { get; set; }

        public HexadecimalNumber(string input)
        {
            INumber number = new NumberModel(input, 16);
            Base = number.Base;
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }
    }
}