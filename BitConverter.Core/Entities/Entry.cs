using System.Linq;
using BitConverter.Auxiliaries;
using BitConverter.Exceptions;
using BitConverter.Interfaces;
using BitConverter.Validators;

namespace BitConverter.Entities
{
    public class Entry : IEntry
    {
        public string IntegerPart { get; }
        public string DecimalPart { get; }

        public Entry(string input)
        {
            if (!Validator.IsValid(input))
                throw new InvalidFormatException("Entered number has a wrong format.");

            var currentInput = input.Replace(Separator.Comma, Separator.Dot);

            if (currentInput.First() == Separator.Dot)
            {
                IntegerPart = "0";
                DecimalPart = new string(currentInput.Skip(1).ToArray());
                return;
            }

            var split = currentInput.Split(Separator.Dot);

            if (split.Length == 2)
            {
                IntegerPart = split[0];
                DecimalPart = split[1];
            }
            else
            {
                IntegerPart = currentInput;
                DecimalPart = "0";
            }
        }
    }
}