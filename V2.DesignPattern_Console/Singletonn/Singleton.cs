namespace V2.DesignPattern_Console.Singletonn
{
    // remark :: Folder name + n to differenate between namespace and Class !!!!  Ambiguity !!
    public class Singleton
    {
        private static Singleton Only_Instance;

        private Singleton() { }

        public static Singleton get_Instance() 
        {
            if (Only_Instance == null)
            {
                Only_Instance = new Singleton();
            }

            return Only_Instance;
        }
    }
}
