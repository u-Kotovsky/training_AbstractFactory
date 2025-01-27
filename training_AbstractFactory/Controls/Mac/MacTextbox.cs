using training_AbstractFactory.Controls.Base;

namespace training_AbstractFactory.Controls.Mac;

public class MacTextbox : Textbox
{
    public override void Paint()
    {
        Console.WriteLine("MacTextbox Paint()");
    }
}
