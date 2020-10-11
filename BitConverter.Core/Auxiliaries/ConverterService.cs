using System;
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

        public static string ConvertIntegerPartToDecimal(IEntry entry)
        {
            if (entry.Base == 10)
                return entry.IntegerPart;

            Builder.Clear();

            var model = ConvertToDecimalIntegerModels(entry);

            double result = 0;

            foreach (var m in model)
            {
                var power = m.Power;
                var bit = m.BitValue;
                result += bit * Math.Pow(m.Base, power);
            }

            return result.ToString(CultureInfo.InvariantCulture);
        }

        /*
         * It selects the enumerable of convert model in order to be converted to decimal integer
         */
        public static IEnumerable<ConvertToDecimalIntegerModel> ConvertToDecimalIntegerModels(IEntry entry)
        {
            var hexTable = BitTable.HexadecimalTable;
            var hexTableLength = hexTable.Length;
            var inputLength = entry.IntegerPart.Length;
            var bits = hexTable.Skip(hexTableLength - inputLength).ToArray();

            for (var i = 0; i < bits.Length; i++)
            {
                yield return new ConvertToDecimalIntegerModel
                {
                    Bit = entry.IntegerPart[i],
                    Power = inputLength - 1 - i,
                    Base = entry.Base
                };
            }
        }
    }
}