namespace BitConverter.Interfaces
{
    public interface INumber
    {
        int Base { get; }
        string IntegerPart { get; }
        string FloatPart { get; }
    }
}