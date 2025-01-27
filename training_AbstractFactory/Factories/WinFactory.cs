using training_AbstractFactory.Controls;
using training_AbstractFactory.Controls.Base;
using training_AbstractFactory.Controls.Win;

namespace training_AbstractFactory.Factories;

public class WinFactory : GUIFactory
{
    public Button CreateButton()
    {
        return new WinButton();
    }

    public Checkbox CreateCheckbox()
    {
        return new WinCheckbox();
    }

    public Label CreateLabel()
    {
        return new WinLabel();
    }

    public RadioButton CreateRadioButton()
    {
        return new WinRadioButton();
    }

    public Textbox CreateTextbox()
    {
        return new WinTextbox();
    }
}
