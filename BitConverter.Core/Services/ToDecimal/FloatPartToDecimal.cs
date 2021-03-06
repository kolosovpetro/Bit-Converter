﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Services.ToDecimal
{
    public static class FloatPartToDecimal
    {
        private static readonly StringBuilder Builder = new StringBuilder();
        private const int Precision = 6;
        
        public static string Convert(INumber entry)
        {
            if (entry.Base == 10)
                return entry.FloatPart;

            Builder.Clear();

            var model = ConvertFloatModel(entry);

            double result = 0;

            foreach (var m in model)
            {
                var power = m.Power;
                var bit = m.BitValue;
                result += bit * Math.Pow(m.Base, power);
            }

            return new string(Math.Round(result, Precision)
                .ToString(CultureInfo.InvariantCulture)
                .Skip(2)
                .ToArray());
        }
        
        private static IEnumerable<PolynomialModel> ConvertFloatModel(INumber entry)
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