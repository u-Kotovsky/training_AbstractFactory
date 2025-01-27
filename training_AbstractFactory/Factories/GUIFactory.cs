using training_AbstractFactory.Controls;
using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Factories
{
    public interface GUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
        Label CreateLabel();
        RadioButton CreateRadioButton();
        Textbox CreateTextbox();
    }
}
