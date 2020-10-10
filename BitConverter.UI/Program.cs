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
            var entry = new Entry("1010101", 2);
            var model = ConverterService
                .ConvertToDecimalIntegerModels(entry)
                .ToList();

            model.ForEach(Console.WriteLine);
            var convertInt = ConverterService.ConvertIntegerPartToDecimal(entry);
            Console.WriteLine(convertInt);
        }
    }
}