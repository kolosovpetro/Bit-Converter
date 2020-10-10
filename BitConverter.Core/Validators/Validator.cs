using System.Linq;
using System.Text.RegularExpressions;
using BitConverter.Auxiliaries;

namespace BitConverter.Validators
{
    public static class Validator
    {
        private static readonly Regex Regex = new Regex(@"[+-]?((\d+\.?\d*)|(\.\d+))");

        public static bool IsValid(string input)
        {
            var match = Regex.Match(input);
            return match.Success;
        }

        public static bool IsProperBinary(string input)
        {
            return input.All(x => BitTable.BinaryTable.Contains(x));
        }

        public static bool IsProperOctal(string input)
        {
            return input.All(x => BitTable.OctalTable.Contains(x));
        }
        
        public static bool IsProperDecimal(string input)
        {
            return input.All(x => BitTable.DecimalTable.Contains(x));
        }

        public static bool IsProperHexadecimal(string input)
        {
            return input.All(x => BitTable.HexadecimalTable.Contains(x));
        }
    }
}