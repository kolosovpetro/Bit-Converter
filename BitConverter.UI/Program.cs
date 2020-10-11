using System;
using System.Linq;
using BitConverter.Entities;
using BitConverter.Services;

namespace BitConverter.UI
{
    public static class Program
    {
        private static void Main()
        {
            var entry = new Entry("101.123", 8);
            var integerModel = ConverterService
                .ConvertIntegerModel(entry)
                .ToList();

            var floatModel = ConverterService
                .ConvertFloatModel(entry)
                .ToList();

            Console.WriteLine("Integer part: ");
            integerModel.ForEach(Console.WriteLine);
            Console.WriteLine("Float Part: ");
            floatModel.ForEach(Console.WriteLine);
            var convertInt = ConverterService.ConvertIntegerPartToDecimal(entry);
            var convertFloat = ConverterService.ConvertFloatPartToDecimal(entry);
            Console.WriteLine($"Integer part in decimal: {convertInt}");
            Console.WriteLine($"Float part in decimal: {convertFloat}");
        }
    }
}