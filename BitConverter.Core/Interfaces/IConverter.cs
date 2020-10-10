namespace BitConverter.Interfaces
{
    public interface IConverter
    {
        /*
         * This method converts particular IEntity which is under roof to new one, depends on base of
         * concrete converter
         */
        IEntry Convert();
    }
}