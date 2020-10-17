using BitConverter.Interfaces;

namespace BitConverter.Converters
{
    /// <summary>
    /// Converts provided entry to decimal format
    /// </summary>
    public class DecimalConverter: IConverter
    {
        private readonly INumber _number;

        public DecimalConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            throw new System.NotImplementedException();
        }
    }
}