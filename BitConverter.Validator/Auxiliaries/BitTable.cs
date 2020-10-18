namespace BitConverter.Validator.Auxiliaries
{
    public static class BitTable
    {
        public static readonly char[] HexadecimalTable =
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'
        };

        public static readonly char[] OctalTable =
        {
            '0', '1', '2', '3', '4', '5', '6', '7'
        };

        public static readonly char[] DecimalTable =
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        public static readonly char[] BinaryTable =
        {
            '0', '1'
        };
    }
}