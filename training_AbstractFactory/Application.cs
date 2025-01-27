using training_AbstractFactory.Controls;
using training_AbstractFactory.Controls.Base;
using training_AbstractFactory.Factories;

namespace training_AbstractFactory;

public class Application
{
    private GUIFactory factory;
    private Button button;
    private Checkbox checkbox;
    private Label label;
    private RadioButton radioButton;
    private Textbox textbox;

    public Application(GUIFactory factory)
    {
        this.factory = factory;
    }

    public void CreateUI()
    {
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();
        label = factory.CreateLabel();
        radioButton = factory.CreateRadioButton();
        textbox = factory.CreateTextbox();
    }

    public void Paint()
    {
        button.Paint();
        checkbox.Paint();
        label.Paint();
        radioButton.Paint();
        textbox.Paint();
    }
}
