using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Mac;

public class MacRadioButton : RadioButton
{
    public override void Paint()
    {
        Console.WriteLine("MacRadioButton Paint()");
    }
}
