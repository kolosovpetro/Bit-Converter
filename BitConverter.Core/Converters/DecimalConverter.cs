using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using BitConverter.Services.ToDecimal;

namespace BitConverter.Converters
{
    /// <summary>
    /// Converts provided entry to decimal format
    /// </summary>
    public class DecimalConverter: IConverter
    {
        private readonly INumber _number;
        private const int Base = NumberBase.Decimal;

        public DecimalConverter(INumber number)
        {
            _number = number;
        }

        public INumber Convert()
        {
            if (_number.Base == Base)
                return _number;

            var integerPart = IntegerPartToDecimal.Convert(_number);
            var floatPart = FloatPartToDecimal.Convert(_number);
            var numberData = integerPart + Separator.Dot + floatPart;
            return new DecimalNumber(numberData);
        }
    }
}