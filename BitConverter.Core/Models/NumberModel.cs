using System;
using System.Linq;
using BitConverter.Auxiliaries;
using BitConverter.Exceptions;
using BitConverter.Interfaces;
using BitConverter.Validators;

namespace BitConverter.Models
{
    /// <summary>
    /// This class represents number model with base, float part, integer part
    /// </summary>
    public class NumberModel : INumber
    {
        public int Base { get; set; }
        public string IntegerPart { get; set; }
        public string FloatPart { get; set; }

        private bool IsOctal => Base == 8;
        private bool IsHexadecimal => Base == 16;

        public NumberModel(string input, int inputBase)
        {
            if (input == null)
                throw new NullNumberException("Input data cannot be null.");

            if (input == string.Empty)
                throw new InvalidNumberFormatException("Input data cannot be empty.");

            if (!Validator.IsValidHexadecimal(input) && !Validator.IsValid(input))
                throw new InvalidNumberFormatException("Entered number has a wrong format.");

            Base = inputBase;

            var currentInput = input.Replace(Separator.Comma, Separator.Dot);

            if (currentInput.First() == Separator.Dot)
            {
                FloatPart = new string(currentInput.Skip(1).ToArray());
                IntegerPart = "0";
                return;
            }

            var split = currentInput.Split(Separator.Dot);

            if (split.Length == 2)
            {
                IntegerPart = split[0];
                var floatPart = split[1] == "" ? "0" : split[1];
                FloatPart = floatPart;
            }
            else
            {
                IntegerPart = currentInput;
                FloatPart = "0";
            }

            if (!Validator.IsProperNumber(IntegerPart, inputBase) || !Validator.IsProperNumber(FloatPart, inputBase))
                throw new InvalidNumberFormatException("Entered number has a wrong format.");
        }

        public override string ToString()
        {
            if (IsOctal)
                return Prefix.Octal + IntegerPart + Separator.Dot + FloatPart;

            if (IsHexadecimal)
                return Prefix.Hexadecimal + IntegerPart + Separator.Dot + FloatPart;

            return IntegerPart + Separator.Dot + FloatPart;
        }
    }
}