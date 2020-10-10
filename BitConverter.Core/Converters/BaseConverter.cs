using BitConverter.Interfaces;

namespace BitConverter.Converters
{
    public abstract class BaseConverter : IConverter
    {
        public IEntry Convert()
        {
            throw new System.NotImplementedException();
        }
    }
}