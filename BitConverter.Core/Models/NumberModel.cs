﻿using System.Linq;
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
        public int Base { get; }
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public NumberModel(string input, int inputBase)
        {
            VerifyInput(input);

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
                FloatPart = split[1] == string.Empty ? "0" : split[1];
                return;
            }

            IntegerPart = currentInput;
            FloatPart = "0";

            if (!Validator.IsProperNumber(IntegerPart, inputBase) || !Validator.IsProperNumber(FloatPart, inputBase))
                throw new InvalidNumberFormatException("Entered number has a wrong format.");
        }

        private static void VerifyInput(string input)
        {
            if (input == null)
                throw new NullNumberException("Input data cannot be null.");

            if (input == string.Empty)
                throw new InvalidNumberFormatException("Input data cannot be empty.");

            if (!Validator.IsValidHexadecimal(input) && !Validator.IsValid(input))
                throw new InvalidNumberFormatException("Entered number has a wrong format.");
        }
    }
}