using training_AbstractFactory.Factories;

namespace training_AbstractFactory;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Application Win:");
        var applicationWin = new Application(new WinFactory());

        applicationWin.CreateUI();
        applicationWin.Paint();

        Console.WriteLine("\nApplication Mac:");

        var applicationMac = new Application(new MacFactory());

        applicationMac.CreateUI();
        applicationMac.Paint();
    }
}