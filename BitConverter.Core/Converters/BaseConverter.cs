using BitConverter.Interfaces;

namespace BitConverter.Converters
{
    public abstract class BaseConverter : IConverter
    {
        public abstract string Convert(string input, int inputBase);

        protected string Convert(string input, int inputBase, int outputBase)
        {
            return null;
        }
    }
}