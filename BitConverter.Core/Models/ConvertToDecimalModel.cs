using System;
using BitConverter.Auxiliaries;

namespace BitConverter.Models
{
    public class ConvertToDecimalModel
    {
        public char Bit { get; set; }
        public int BitValue => Array.IndexOf(BitTable.HexadecimalTable, Bit);
        public double Power { get; set; }
        public double Base { get; set; }

        public override string ToString()
        {
            return $"Bit = {Bit}, BitValue = {BitValue}, Base = {Base}, Power = {Power}";
        }
    }
}