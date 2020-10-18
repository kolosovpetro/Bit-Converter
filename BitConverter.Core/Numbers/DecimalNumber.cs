﻿using BitConverter.Interfaces;
using BitConverter.Models;
using BitConverter.Validator.Auxiliaries;
using NumberBase = BitConverter.Auxiliaries.NumberBase;

namespace BitConverter.Numbers
{
    public class DecimalNumber : INumber
    {
        public int Base { get; }
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public DecimalNumber(string input)
        {
            var number = new NumberModel(input, NumberBase.Decimal);
            Base = number.Base;
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }

        public override string ToString()
        {
            return IntegerPart + Separator.Dot + FloatPart;
        }
    }
}