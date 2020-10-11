namespace BitConverter.Interfaces
{
    public interface INumber
    {
        int Base { get; set; }
        string IntegerPart { get; set; }
        string FloatPart { get; set; }
    }
}