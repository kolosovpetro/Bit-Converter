using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using BitConverter.Services;

namespace BitConverter.Converters
{
    /// <summary>
    /// Converts provided entry to hexadecimal format
    /// </summary>
    public class HexadecimalConverter: IConverter
    {
        private readonly INumber _number;
        private const int Base = NumberBase.Hexadecimal;

        public HexadecimalConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            if (_number.Base == Base)
                return _number;

            var numberData = ConverterService.ConvertData(_number, Base);
            return new HexadecimalNumber(numberData);
        }
    }
}