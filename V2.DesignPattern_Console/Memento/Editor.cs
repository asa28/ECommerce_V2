namespace V2.DesignPatterns.Memento
{
    public class Editor
    {
        private string content;

        public string getContent() 
        {
            return content;
        }

        public void setContent(string _content) 
        {
            this.content = _content;
        }


        public EditorState createState()
        {
            return new EditorState(content);
        }

        public void restore(EditorState state)
        {
            content = state.getContent();
        }
    }
}
