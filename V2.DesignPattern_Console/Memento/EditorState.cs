namespace V2.DesignPatterns
{
    public class EditorState
    {

        private string _Content;

        public EditorState(string content)
        {
            this._Content = content;
        }

        public string getContent() 
        {
            return _Content;
        }
    }
}
