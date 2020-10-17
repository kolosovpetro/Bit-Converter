using BitConverter.Interfaces;

namespace BitConverter.Converters
{
    /// <summary>
    /// Converts provided entry to octal format
    /// </summary>
    public class OctalConverter : IConverter
    {
        private readonly INumber _number;

        public OctalConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            throw new System.NotImplementedException();
        }
    }
}