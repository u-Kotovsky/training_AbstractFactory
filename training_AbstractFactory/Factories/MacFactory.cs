using training_AbstractFactory.Controls;
using training_AbstractFactory.Controls.Base;
using training_AbstractFactory.Controls.Mac;

namespace training_AbstractFactory.Factories;

public class MacFactory : GUIFactory
{
    public Button CreateButton()
    {
        return new MacButton();
    }

    public Checkbox CreateCheckbox()
    {
        return new MacCheckbox();
    }

    public Label CreateLabel()
    {
        return new MacLabel();
    }

    public RadioButton CreateRadioButton()
    {
        return new MacRadioButton();
    }

    public Textbox CreateTextbox()
    {
        return new MacTextbox();
    }
}
