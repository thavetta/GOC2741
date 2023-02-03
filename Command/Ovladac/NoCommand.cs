namespace Ovladac;

public class NoCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Nedelam nic");
    }
}