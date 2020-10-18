using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Numbers;
using BitConverter.Services.FromDecimal;
using BitConverter.Services.ToDecimal;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Services
{
    public static class ConverterService
    {
        public static INumber ConvertToDecimal(INumber number)
        {
            var integerPart = IntegerPartToDecimal.Convert(number);
            var floatPart = FloatPartToDecimal.Convert(number);
            var numberData = integerPart + Separator.Dot + floatPart;
            return new DecimalNumber(numberData);
        }

        private static INumber ConvertFromDecimal(INumber number, int newBase)
        {
            var decimalNumber = ConvertToDecimal(number);
            var integerPartFromDecimal = IntegerPartFromDecimal.Convert(decimalNumber, newBase);
            var floatPartFromDecimal = FloatPartFromDecimal.Convert(decimalNumber, newBase);
            var data = integerPartFromDecimal + Separator.Dot + floatPartFromDecimal;
            return new NumberModel(data, newBase);
        }

        public static INumber ConvertToBase(INumber number, int newBase)
        {
            var decimalNumber = ConvertToDecimal(number);
            return ConvertFromDecimal(decimalNumber, newBase);
        }
    }
}