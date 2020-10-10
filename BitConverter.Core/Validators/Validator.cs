using System.Text.RegularExpressions;

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

        public static bool IsDotSeparated(string input)
        {
            return input.Contains('.');
        }
    }
}