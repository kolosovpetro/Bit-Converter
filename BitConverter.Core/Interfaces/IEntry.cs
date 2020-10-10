namespace BitConverter.Interfaces
{
    public interface IEntry
    {
        int Base { get; set; }
        string IntegerPart { get; set; }
        string DecimalPart { get; set; }
    }
}