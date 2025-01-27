using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Mac;

public class MacLabel : Label
{
    public override void Paint()
    {
        Console.WriteLine("MacLabel Paint()");
    }
}
