namespace V2.DesignPattern_Console.Strategy.Implementaion
{
    public class JPEG_Compressor : ICompressor
    {
        public void compress(string FileName)
        {
            System.Console.WriteLine("Compressing Using JPEG");
        }
    }
}
