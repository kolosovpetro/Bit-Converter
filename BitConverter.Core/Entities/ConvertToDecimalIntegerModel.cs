namespace BitConverter.Entities
{
    public class ConvertToDecimalIntegerModel
    {
        public char Bit { get; set; }
        public int Power { get; set; }
        public int Base { get; set; }

        public override string ToString()
        {
            return $"Bit = {Bit}, Base = {Base}, Power = {Power}";
        }
    }
}