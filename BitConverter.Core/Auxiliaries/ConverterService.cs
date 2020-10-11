﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BitConverter.Entities;
using BitConverter.Interfaces;

namespace BitConverter.Auxiliaries
{
    public static class ConverterService
    {
        private static readonly StringBuilder Builder = new StringBuilder();
        private static readonly int Precision = 4;

        public static string ConvertIntegerPartToDecimal(IEntry entry)
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
        
        public static string ConvertFloatPartToDecimal(IEntry entry)
        {
            if (entry.Base == 10)
                return entry.IntegerPart;

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

        /*
         * It selects the enumerable of convert model in order to be converted to decimal integer
         */
        public static IEnumerable<ConvertToDecimalModel> ConvertIntegerModel(IEntry entry)
        {
            var hexTable = BitTable.HexadecimalTable;
            var hexTableLength = hexTable.Length;
            var inputLength = entry.IntegerPart.Length;
            var bits = hexTable.Skip(hexTableLength - inputLength).ToArray();

            for (var i = 0; i < bits.Length; i++)
            {
                yield return new ConvertToDecimalModel
                {
                    Bit = entry.IntegerPart[i],
                    Power = inputLength - 1 - i,
                    Base = entry.Base
                };
            }
        }

        public static IEnumerable<ConvertToDecimalModel> ConvertFloatModel(IEntry entry)
        {
            var hexTable = BitTable.HexadecimalTable;
            var hexTableLength = hexTable.Length;
            var inputLength = entry.FloatPart.Length;
            var bits = hexTable.Skip(hexTableLength - inputLength).ToArray();

            for (var i = 0; i < bits.Length; i++)
            {
                yield return new ConvertToDecimalModel
                {
                    Bit = entry.FloatPart[i],
                    Power = -1 - i,
                    Base = entry.Base
                };
            }
        }
    }
}