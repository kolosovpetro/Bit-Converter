namespace BitConverter.Auxiliaries
{
    public static class BitTable
    {
        public static readonly char[] HexadecimalTable =
        {
            'F', 'E', 'D', 'C', 'B', 'A', '9', '8', '7', '6', '5', '4', '3', '2', '1', '0'
        };

        public static readonly char[] OctalTable =
        {
            '7', '6', '5', '4', '3', '2', '1', '0'
        };

        public static readonly char[] DecimalTable =
        {
            '9', '8', '7', '6', '5', '4', '3', '2', '1', '0'
        };

        public static readonly char[] BinaryTable =
        {
            '0', '1'
        };
    }
}