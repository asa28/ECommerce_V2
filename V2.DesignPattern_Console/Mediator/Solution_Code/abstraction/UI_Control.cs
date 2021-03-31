using V2.DesignPattern_Console.Mediator.Solution_Code.abstraction;

namespace V2.DesignPattern_Console.Mediator.Solution_Code
{
    public abstract class UI_Control
    {
        protected DialougBox Owner;
        protected UI_Control() { }

        public UI_Control(DialougBox owner) 
        {
            Owner = owner;
        }

    }
}