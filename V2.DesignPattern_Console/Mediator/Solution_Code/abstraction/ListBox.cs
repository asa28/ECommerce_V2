namespace V2.DesignPattern_Console.Mediator.Solution_Code.abstraction
{
    public class ListBox:UI_Control
    {
        public ListBox(DialougBox owner)
        {
            this.Owner = owner;
        }

        private string _selection;

        public string getSelection()
        {
            return _selection;
        }

        public void setSelection(string selection) 
        {
            _selection = selection;
            Owner.changed(this);
        }
    }
}