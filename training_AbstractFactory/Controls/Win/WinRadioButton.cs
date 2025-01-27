using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Win;

public class WinRadioButton : RadioButton
{
    public override void Paint()
    {
        Console.WriteLine("WinRadioButton Paint()");
    }
}
