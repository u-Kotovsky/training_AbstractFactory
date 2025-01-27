namespace training_AbstractFactory.Controls.Win;

public class WinCheckbox : Checkbox
{
    public override void Paint()
    {
        Console.WriteLine("WinCheckbox Paint()");
    }
}