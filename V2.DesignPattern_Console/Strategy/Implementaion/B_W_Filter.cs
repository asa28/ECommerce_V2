namespace V2.DesignPattern_Console.Strategy.Implementaion
{
    public class B_W_Filter : IFilter
    {
        public void apply(string FileName)
        {
            System.Console.WriteLine("apply B&W filter");
        }
    }
}
