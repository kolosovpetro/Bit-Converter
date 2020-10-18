using BitConverter.Interfaces;
using BitConverter.Numbers;
using BitConverter.Services;

namespace BitConverter.Converters
{
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

            var number = ConverterService.ConvertToBase(_number, 2);
            return new BinaryNumber(number.ToString());
        }
    }
}