using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Models;

namespace BitConverter.Services.ToDecimal
{
    public static class IntegerPartToDecimal
    {
        private static readonly StringBuilder Builder = new StringBuilder();

        /// <summary>
        /// This converts only INTEGER part of Entry
        /// </summary>
        public static string Convert(INumber entry)
        {
            if (entry.Base == 10)
                return entry.IntegerPart;

            Builder.Clear();

            var model = IntegerPartPolynomial(entry);

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
        /// This gives an enumeration of models, which helps to perform easier conversion from
        /// integer part of an entry to decimal
        /// </summary>
        public static IEnumerable<PolynomialModel> IntegerPartPolynomial(INumber entry)
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
    }
}