namespace BitConverter.Interfaces
{
    public interface IConverter
    {
        /// <summary>
        /// Converts an input of a string to particular bitcode related to output base.
        /// </summary>
        IEntry Convert();
    }
}