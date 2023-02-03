namespace Ovladac;

public class VypniSvetloCommand : ICommand
{
    private Svetlo svetlo;

    public VypniSvetloCommand(Svetlo svetlo)
    {
        this.svetlo = svetlo;
    }

    public void Execute()
    {
        svetlo.Vypni();
    }
}