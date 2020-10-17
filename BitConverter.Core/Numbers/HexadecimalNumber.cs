﻿using BitConverter.Auxiliaries;
using BitConverter.Interfaces;
using BitConverter.Models;

namespace BitConverter.Numbers
{
    public class HexadecimalNumber : INumber
    {
        public int Base { get; }
        public string IntegerPart { get; }
        public string FloatPart { get; }

        public HexadecimalNumber(string input)
        {
            INumber number = new NumberModel(input, 16);
            Base = number.Base;
            IntegerPart = number.IntegerPart;
            FloatPart = number.FloatPart;
        }

        public override string ToString()
        {
            return Prefix.Hexadecimal + IntegerPart + Separator.Dot + FloatPart;
        }
    }
}