namespace V2.DesignPattern_Console.Mediator.Solution_Code.abstraction
{
    public class TextBox : UI_Control
    {
        public TextBox(DialougBox owner)
        {
            this.Owner = owner;
        }

        private string _content;

        public string getContent()
        {
            return _content;
        }

        public void setContent(string content)
        {
            _content = content;
            Owner.changed(this);
        }
    }
}