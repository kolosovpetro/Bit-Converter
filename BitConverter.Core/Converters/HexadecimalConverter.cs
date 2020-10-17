using BitConverter.Interfaces;

namespace BitConverter.Converters
{
    /// <summary>
    /// Converts provided entry to hexadecimal format
    /// </summary>
    public class HexadecimalConverter: IConverter
    {
        private readonly INumber _number;

        public HexadecimalConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            throw new System.NotImplementedException();
        }
    }
}