namespace BitConverter.Interfaces
{
    public interface IConverter
    {
        string Convert(string input, int inputBase, int toBase);
    }
}