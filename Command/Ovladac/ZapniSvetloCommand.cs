namespace Ovladac;

public class ZapniSvetloCommand : ICommand
{
    private Svetlo svetlo;

    public ZapniSvetloCommand(Svetlo svetlo)
    {
        this.svetlo = svetlo;
    }

    public void Execute()
    {
        svetlo.Zapni();
    }
}