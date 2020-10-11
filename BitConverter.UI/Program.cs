using System;
using System.Linq;
using BitConverter.Auxiliaries;
using BitConverter.Entities;

namespace BitConverter.UI
{
    public static class Program
    {
        private static void Main()
        {
            var entry = new Entry("101.123", 8);
            var integerModel = ConverterService
                .ConvertToDecimalIntegerPart(entry)
                .ToList();
            
            var floatModel = ConverterService
                .ConvertToDecimalFloatPart(entry)
                .ToList();

            //integerModel.ForEach(Console.WriteLine);
            floatModel.ForEach(Console.WriteLine);
            var convertInt = ConverterService.ConvertIntegerPartToDecimal(entry);
            Console.WriteLine(convertInt);
        }
    }
}