namespace V2.DesignPattern_Console.Mediator.abstraction_Level
{
    public class TextBox: UI_Control
    {

        public TextBox(DialougBox _Owner) : base(_Owner) { }



        private string content;

        public string getContent()
        {
            return content;
        }

        public void setContent(string _content)
        {
            content = _content;
            owner.changed(this);
        }
    }
}