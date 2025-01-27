using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Win;

public class WinButton : Button
{
    public override void Paint()
    {
        Console.WriteLine("WinButton Paint()");
    }
}
