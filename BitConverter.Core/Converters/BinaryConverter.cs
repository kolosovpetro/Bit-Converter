using System.Linq;
using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using BitConverter.Services.FromDecimal;
using BitConverter.Services.ToDecimal;

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
            
            // convert to decimal
            var integerToDecimal = IntegerPartToDecimal.Convert(_number);
            var floatPartToDecimal = new string(FloatPartToDecimal.Convert(_number).Skip(2).ToArray());
            var input = integerToDecimal + Separator.Dot + floatPartToDecimal;
            var decimalNumber = new DecimalNumber(input);
            
            // convert from decimal
            var integerPartFromDecimal = IntegerPartFromDecimal.Convert(decimalNumber, Base);
            var floatPartFromDecimal = FloatPartFromDecimal.Convert(decimalNumber, Base);
            input = integerPartFromDecimal + Separator.Dot + floatPartFromDecimal;
            return new BinaryNumber(input);
        }
    }
}