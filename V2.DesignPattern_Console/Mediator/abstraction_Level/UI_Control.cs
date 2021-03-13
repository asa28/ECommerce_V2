namespace V2.DesignPattern_Console.Mediator.abstraction_Level
{
    public class UI_Control
    {
        protected DialougBox owner;

        public UI_Control(DialougBox _owner)
        {
            this.owner = _owner;
        }
    }
}