using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BitConverter.Interfaces;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Services.FromDecimal
{
    public static class FloatPartFromDecimal
    {
        private static readonly StringBuilder Builder = new StringBuilder();
        private const int Precision = 6;

        public static string Convert(INumber number, int newBase)
        {
            if (newBase == 10)
                return Math.Round(double.Parse(number.FloatPart)).ToString(CultureInfo.CurrentCulture);

            var currentFloat = double.Parse("0," + number.FloatPart);

            var queue = new Queue<char>();

            for (var i = 0; i < Precision; i++)
            {
                currentFloat *= newBase;
                var item = (int) currentFloat;
                queue.Enqueue(BitTable.HexadecimalTable[item]);
                currentFloat -= (int) currentFloat;
            }

            Builder.Clear();

            while (queue.Any())
                Builder.Append(queue.Dequeue());

            return Builder.ToString();
        }
    }
}