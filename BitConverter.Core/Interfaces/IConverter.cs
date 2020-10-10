namespace BitConverter.Interfaces
{
    public interface IConverter
    {
        /// <summary>
        /// Converts an input of a string to particular bitcode related to output base.
        /// </summary>
        string Convert(string input, int inputBase);
    }
}