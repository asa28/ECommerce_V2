namespace V2.DesignPattern_Console.Strategy
{
    public class ImageStorage
    {
        //private ICompressor _compressor;
        //private IFilter _filter;

        //public ImageStorage(ICompressor compressor, IFilter filter)
        //{
        //    this._compressor = compressor;
        //    this._filter = filter;
        //}

        public void store(string FileName, ICompressor compressor, IFilter filter)
        {
            compressor.compress(FileName);
            filter.apply(FileName);
        }
    }
}
