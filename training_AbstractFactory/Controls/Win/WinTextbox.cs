using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Win;

public class WinTextbox : Textbox
{
    public override void Paint()
    {
        Console.WriteLine("WinTextbox Paint()");
    }
}
