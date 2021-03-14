namespace V2.DesignPattern_Console.Strategy.Implementaion
{
    public class High_Contrast_Filter : IFilter
    {
        public void apply(string FileName)
        {
            System.Console.WriteLine("apply High Contrast Filter");
        }
    }
}
