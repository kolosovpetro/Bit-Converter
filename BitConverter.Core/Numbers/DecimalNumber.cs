using BitConverter.Interfaces;
using BitConverter.Models;

namespace BitConverter.Numbers
{
    public class DecimalNumber : INumber
    {
        public int Base { get; set; }
        public string IntegerPart { get; set; }
        public string FloatPart { get; set; }

        public DecimalNumber(string input)
        {
            INumber number = new NumberModel(input, 10);
            Base = number.Base;
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }
    }
}