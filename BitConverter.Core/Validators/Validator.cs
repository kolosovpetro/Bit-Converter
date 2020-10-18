using System.Linq;
using System.Text.RegularExpressions;
using BitConverter.Auxiliaries;
using BitConverter.Exceptions;

namespace BitConverter.Validators
{
    public static class Validator
    {
        private static readonly Regex Regex = new Regex(@"[+-]?((\d+\.?\d*)|(\.\d+))");
        private static readonly Regex RegexHexadecimal = new Regex(@"[+-]?[A-F0-9]*?\.[A-F0-9]*");

        public static bool IsValid(string input)
        {
            var match = Regex.Match(input);
            return match.Success;
        }
        
        public static bool IsValidHexadecimal(string input)
        {
            var match = RegexHexadecimal.Match(input);
            return match.Success;
        }

        public static bool IsProperBinary(string input)
        {
            return string.IsNullOrEmpty(input) || input.All(x => BitTable.BinaryTable.Contains(x));
        }

        public static bool IsProperOctal(string input)
        {
            return string.IsNullOrEmpty(input) || input.All(x => BitTable.OctalTable.Contains(x));
        }

        public static bool IsProperDecimal(string input)
        {
            return string.IsNullOrEmpty(input) || input.All(x => BitTable.DecimalTable.Contains(x));
        }

        public static bool IsProperHexadecimal(string input)
        {
            return string.IsNullOrEmpty(input) || input.All(x => BitTable.HexadecimalTable.Contains(x));
        }

        // this is to verify proper format on entry
        public static bool IsProperNumber(string input, int inputBase)
        {
            return inputBase switch
            {
                2 => IsProperBinary(input),
                8 => IsProperOctal(input),
                10 => IsProperDecimal(input),
                16 => IsProperHexadecimal(input),
                _ => throw new UnsupportedBaseException("Provided base is not supported.")
            };
        }
    }
}