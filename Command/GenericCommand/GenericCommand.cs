namespace GenericCommand;

public class GenericCommand : ICommand
{
    private Action<object?> akce;

    public GenericCommand(Action<object?> akce)
    {
        this.akce = akce;
    }

    public void Execute(object? parameter)
    {
        akce.Invoke(parameter);
    }
}