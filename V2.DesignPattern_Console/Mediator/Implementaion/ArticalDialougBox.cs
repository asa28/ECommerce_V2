using V2.DesignPattern_Console.Mediator.abstraction_Level;

namespace V2.DesignPattern_Console.Mediator.Implementaion
{
    public class ArticalDialougBox : DialougBox
    {

        private ListBox _articalListBox;
        private TextBox _titleBox;
        private Button _button;

        public ArticalDialougBox()
        {
            _articalListBox = new ListBox(this);
            _titleBox = new TextBox(this);
            _button = new Button(this);
        }

        public override void changed(UI_Control ui_Control)
        {
            if (ui_Control == _articalListBox)
                articalSelected();
            else if (ui_Control == _titleBox)
                titleChanged();
        }


        private void articalSelected()
        {
            _titleBox.setContent(_articalListBox.getSelection());
            _button.setButton(true);
        }


        private void titleChanged()
        {
            var content = _titleBox.getContent();
            var Is_Empty = (content == null || content.Length == 0) ? false : true;
            _button.setButton(Is_Empty);
        }

        private void buttonSelected()
        { 
            
        }


        public void SimulateUserInteraction()
        {
            _articalListBox.setSelection("this is artical 1  ");
            _titleBox.setContent("");
            System.Console.WriteLine("TitleBox : " + _titleBox.getContent());
            System.Console.WriteLine("Button : " + _button.getButton());
        }

    }

}