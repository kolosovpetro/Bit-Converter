using BitConverter.Converters;
using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Services.FromDecimal;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Services
{
    public static class ConverterService
    {
        public static string ConvertData(INumber number, int newBase)
        {
            // convert to decimal
            var decimalConverter = new DecimalConverter(number);
            var decimalNumber = decimalConverter.Convert();

            // convert from decimal
            var integerPartFromDecimal = IntegerPartFromDecimal.Convert(decimalNumber, newBase);
            var floatPartFromDecimal = FloatPartFromDecimal.Convert(decimalNumber, newBase);
            return integerPartFromDecimal + Separator.Dot + floatPartFromDecimal;
        }

        private static INumber ConvertToDecimal(INumber number)
        {
            var decimalConverter = new DecimalConverter(number);
            return decimalConverter.Convert();
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