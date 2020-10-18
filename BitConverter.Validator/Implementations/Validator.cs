using System;
using System.Linq;
using BitConverter.Validator.Auxiliaries;
using BitConverter.Validator.Interfaces;

namespace BitConverter.Validator.Implementations
{
    public class Validator : IValidator
    {
        public bool IsValidBinary(string input)
        {
            return BaseValidator(input, BitTable.BinaryTable);
        }

        public bool IsValidOctal(string input)
        {
            return BaseValidator(input, BitTable.OctalTable);
        }

        public bool IsValidDecimal(string input)
        {
            return BaseValidator(input, BitTable.DecimalTable);
        }

        public bool IsValidHexadecimal(string input)
        {
            return BaseValidator(input, BitTable.HexadecimalTable);
        }

        public bool Validate(string input, int inputBase)
        {
            switch (inputBase)
            {
                case 2:
                    return IsValidBinary(input);
                case 8:
                    return IsValidOctal(input);
                case 10:
                    return IsValidDecimal(input);
                case 16:
                    return IsValidHexadecimal(input);
                default:
                    return false;
            }
        }

        private static bool BaseValidator(string input, char[] arr)
        {
            if (!input.Contains(Separator.Dot)) return false;
            if (input.Contains(Separator.Comma)) return false;
            if (input.Count(x => x == Separator.Dot) > 1) return false;
            if (input == Separator.Dot.ToString()) return false;
            var split = input.Split(Separator.Dot);
            if (split.Contains(string.Empty) || split.Contains(null)) return false;
            return split.All(x => x.All(arr.Contains));
        }
    }
}