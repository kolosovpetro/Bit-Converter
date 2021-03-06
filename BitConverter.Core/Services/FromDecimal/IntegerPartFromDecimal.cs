﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using BitConverter.Interfaces;
using BitConverter.Validator.Auxiliaries;

namespace BitConverter.Services.FromDecimal
{
    public static class IntegerPartFromDecimal
    {
        private static readonly StringBuilder Builder = new StringBuilder();
        
        public static string Convert(INumber entry, int newBase)
        {
            if (newBase == 10)
                return entry.IntegerPart;

            var integralPart = long.Parse(entry.IntegerPart);
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
    }
}