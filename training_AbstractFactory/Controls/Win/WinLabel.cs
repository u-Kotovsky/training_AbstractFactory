using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Win;

internal class WinLabel : Label
{
    public override void Paint()
    {
        Console.WriteLine("WinLabel Paint()");
    }
}
