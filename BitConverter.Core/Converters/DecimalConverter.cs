using BitConverter.Interfaces;
using BitConverter.Services;

namespace BitConverter.Converters
{
    public class DecimalConverter: IConverter
    {
        private readonly INumber _number;
        private const int Base = 10;

        public DecimalConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            if (_number.Base == Base)
                return _number;

            return ConverterService.ConvertToDecimal(_number);
        }
    }
}