namespace V2.DesignPattern_Console.Mediator.abstraction_Level
{
    public class Button:UI_Control
    {

        public Button(DialougBox _Owner) : base(_Owner) { }


        private bool is_Enabled;

        public bool getButton()
        {
            return is_Enabled;
        }

        public void setButton(bool is_Pressed)
        {
            is_Enabled = is_Pressed;
            owner.changed(this);
        }
    }
}