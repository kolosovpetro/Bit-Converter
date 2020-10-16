using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Models;

namespace BitConverter.Services
{
    public static class ConverterService
    {
        private static readonly StringBuilder Builder = new StringBuilder();
        private const int Precision = 4;

        /// <summary>
        /// This converts only INTEGER part of Entry
        /// </summary>
        public static string ConvertIntegerPartToDecimal(INumber entry)
        {
            if (entry.Base == 10)
                return entry.IntegerPart;

            Builder.Clear();

            var model = ConvertIntegerModel(entry);

            double result = 0;

            foreach (var m in model)
            {
                var power = m.Power;
                var bit = m.BitValue;
                result += bit * Math.Pow(m.Base, power);
            }

            return result.ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// This converts only FLOAT part of an entry
        /// </summary>
        public static string ConvertFloatPartToDecimal(INumber entry)
        {
            if (entry.Base == 10)
                return Math.Round(double.Parse("0," + entry.FloatPart), Precision).ToString(CultureInfo.CurrentCulture);

            Builder.Clear();

            var model = ConvertFloatModel(entry);

            double result = 0;

            foreach (var m in model)
            {
                var power = m.Power;
                var bit = m.BitValue;
                result += bit * Math.Pow(m.Base, power);
            }

            return Math.Round(result, Precision).ToString(CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// This gives an enumeration of models, which helps to perform easier conversion from
        /// integer part of an entry to decimal
        /// </summary>
        public static IEnumerable<PolynomialModel> ConvertIntegerModel(INumber entry)
        {
            var hexTable = BitTable.HexadecimalTable;
            var hexTableLength = hexTable.Length;
            var inputLength = entry.IntegerPart.Length;
            var bits = hexTable.Skip(hexTableLength - inputLength).ToArray();

            for (var i = 0; i < bits.Length; i++)
            {
                yield return new PolynomialModel
                {
                    Bit = entry.IntegerPart[i],
                    Power = inputLength - 1 - i,
                    Base = entry.Base
                };
            }
        }

        /// <summary>
        /// This gives an enumeration of models, which helps to perform easier conversion from
        /// float part of an entry to decimal
        /// </summary>
        public static IEnumerable<PolynomialModel> ConvertFloatModel(INumber entry)
        {
            var hexTable = BitTable.HexadecimalTable;
            var hexTableLength = hexTable.Length;
            var inputLength = entry.FloatPart.Length;
            var bits = hexTable.Skip(hexTableLength - inputLength).ToArray();

            for (var i = 0; i < bits.Length; i++)
            {
                yield return new PolynomialModel
                {
                    Bit = entry.FloatPart[i],
                    Power = -1 - i,
                    Base = entry.Base
                };
            }
        }

        /// <summary>
        /// Converts decimal integer part to particular base
        /// </summary>
        public static string ConvertIntegerPartFromDecimal(INumber entry, int newBase)
        {
            if (newBase == 10)
                return entry.IntegerPart;

            var integralPart = int.Parse(entry.IntegerPart);
            var stack = new Stack<string>();


            while (integralPart > 0)
            {
                var remainder = integralPart % newBase;
                stack.Push(BitTable.HexadecimalTable[remainder].ToString());
                integralPart /= newBase;
            }

            Builder.Clear();

            while (stack.Any())
                Builder.Append(stack.Pop());

            return Builder.ToString();
        }

        /// <summary>
        /// This converts decimal float in number model to desired base
        /// </summary>
        public static string ConvertFloatPartFromDecimal(INumber number, int newBase)
        {
            if (newBase == 10)
                return Math.Round(double.Parse(number.FloatPart)).ToString(CultureInfo.CurrentCulture);

            var currentFloat = double.Parse(number.FloatPart);

            var queue = new Queue<string>();

            for (var i = 0; i < Precision; i++)
            {
                currentFloat *= newBase;
                var item = (int) currentFloat;
                queue.Enqueue(item.ToString());
            }

            Builder.Clear();

            while (queue.Any())
                Builder.Append(queue.Dequeue());

            return Builder.ToString();
        }
    }
}