using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Numbers;
using BitConverter.Services.FromDecimal;
using BitConverter.Services.ToDecimal;

namespace BitConverter.Services
{
    public static class ConverterService
    {
        public static string ConvertData(INumber number, int newBase)
        {
            var integerToDecimal = IntegerPartToDecimal.Convert(number);
            var floatPartToDecimal = FloatPartToDecimal.Convert(number);
            var input = integerToDecimal + Separator.Dot + floatPartToDecimal;
            var decimalNumber = new DecimalNumber(input);

            // convert from decimal
            var integerPartFromDecimal = IntegerPartFromDecimal.Convert(decimalNumber, newBase);
            var floatPartFromDecimal = FloatPartFromDecimal.Convert(decimalNumber, newBase);
            return integerPartFromDecimal + Separator.Dot + floatPartFromDecimal;
        }
    }
}