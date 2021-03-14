namespace V2.DesignPattern_Console.Strategy.Implementaion
{
    public class PNG_Compressor : ICompressor
    {
        public void compress(string FileName)
        {
            System.Console.WriteLine("Compressing Using PNG");
        }
    }
}
