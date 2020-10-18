using BitConverter.Interfaces;
using BitConverter.Numbers;
using BitConverter.Services;

namespace BitConverter.Converters
{
    public class OctalConverter : IConverter
    {
        private readonly INumber _number;
        private const int Base = 8;

        public OctalConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            if (_number.Base == Base)
                return _number;

            var number = ConverterService.ConvertToBase(_number, Base);
            return new OctalNumber(number.ToString());
        }
    }
}