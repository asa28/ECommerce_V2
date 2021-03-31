namespace V2.DesignPattern_Console.Mediator.Solution_Code.abstraction
{
    public class Button : UI_Control
    {
        public Button(DialougBox _owner)
        {
            this.Owner = _owner;
        }

        private bool is_Enabled;

        public bool isEnabled()
        {
            return is_Enabled;
        }

        public void setEnabled(bool is_Pressed)
        {
            is_Enabled = is_Pressed;
            Owner.changed(this);
        }
    }
}