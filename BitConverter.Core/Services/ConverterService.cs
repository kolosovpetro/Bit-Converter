using BitConverter.Auxiliaries;
using BitConverter.Converters;
using BitConverter.Interfaces;
using BitConverter.Services.FromDecimal;

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
    }
}