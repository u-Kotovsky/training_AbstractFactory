using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Mac;

public class MacButton : Button
{
    public override void Paint()
    {
        Console.WriteLine("MacButton Paint()");
    }
}
