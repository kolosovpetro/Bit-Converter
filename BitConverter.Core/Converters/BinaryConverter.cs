using BitConverter.Interfaces;
using BitConverter.Numbers;
using BitConverter.Services;

namespace BitConverter.Converters
{
    /// <summary>
    /// Converts provided number to the octal format
    /// </summary>
    public class BinaryConverter : IConverter
    {
        private readonly INumber _number;
        private const int Base = 2;

        public BinaryConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            if (_number.Base == Base)
                return _number;
            
            var convertData = ConverterService.ConvertData(_number, Base);
            return new BinaryNumber(convertData);
        }
    }
}