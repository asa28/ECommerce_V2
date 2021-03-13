namespace V2.DesignPattern_Console.Mediator.abstraction_Level
{
    public class ListBox:UI_Control
    {

        public ListBox(DialougBox _Owner) : base(_Owner) { }



        private string selection;

        public string getSelection()
        {
            return selection;
        }

        public void setSelection(string _Selection) 
        {
            selection = _Selection;
            owner.changed(this);
        }
    }
}