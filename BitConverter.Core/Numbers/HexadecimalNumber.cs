using BitConverter.Interfaces;

namespace BitConverter.Numbers
{
    public class HexadecimalNumber : INumber
    {
        public int Base { get; set; }
        public string IntegerPart { get; set; }
        public string FloatPart { get; set; }
    }
}