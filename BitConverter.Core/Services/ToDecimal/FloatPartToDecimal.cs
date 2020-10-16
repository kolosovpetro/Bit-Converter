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
    public static class FloatPartToDecimal
    {
        private static readonly StringBuilder Builder = new StringBuilder();
        private const int Precision = 4;
        
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
    }
}