using System;
using BitConverter.Converters;
using BitConverter.Numbers;

namespace BitConverter.UI
{
    public static class Program
    {
        private static void Main()
        {
            var hexConverter = new HexadecimalConverter(new DecimalNumber("101010101111.1010"));
            var hexNumber = hexConverter.Convert();
            Console.WriteLine(hexNumber);    // 0x1784ABD377.19DB22
        }
    }
}