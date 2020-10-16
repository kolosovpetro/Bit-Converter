using BitConverter.Interfaces;

namespace BitConverter.Numbers
{
    public class OctalNumber : INumber
    {
        public int Base { get; set; }
        public string IntegerPart { get; set; }
        public string FloatPart { get; set; }
    }
}